using AutoMapper;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.Transacion;
using BusSystem.Services.Extensions;
using BusSystem.Services.Interfaces;
using BusSytem.Services.Implements;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Implements
{
    public class TransactionHisService : ITransactionHisService
    {
        private readonly ITransactionHisRepository _transactionHis;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<TransactionHisService> _logger;
        private readonly UserManager<User> _userManager;

        public TransactionHisService(UserManager<User>  userManager,ILogger<TransactionHisService> logger,IUnitOfWork unitOfWork,ITransactionHisRepository transactionHis, IHttpContextAccessor httpContextAccessor, IUserRepository userRepository, IMapper mapper)
        {
            _transactionHis = transactionHis;
            _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<TransactionHis> CreateTransaction(TransactionHis entity)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                await _transactionHis.InsertAsync(entity);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return entity;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return null;
            }
        }

        public TransactionHis GetById(int id)
        {
            return _transactionHis.GetById(id);
        }

        public List<TranserHisViewModel> ListTransHis(int pageIndex, int pageSize, int? type, int? status, string username)
        {
            var filter = FilterParams(type, status);

            var query = _transactionHis.GetAll()
                .Include(x => x.User)
                .Where(x => string.IsNullOrEmpty(username) ? true : x.User.UserName.Contains(username))
                .Where(x => string.IsNullOrEmpty(type.ToString()) ? true : x.Type.Equals(type))
                .Where(x => string.IsNullOrEmpty(status.ToString()) ? true : x.Status.Equals(status))
                .OrderByDescending(s => s.CreatedDate)
                .Select(x => _mapper.Map<TranserHisViewModel>(x))
                .AsQueryable();
            return PageList<TranserHisViewModel>.Create(query, pageIndex, pageSize, false);

        }
        public static List<FilterExtensions.FilterParams> FilterParams(int? type, int? status)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();

            if (!string.IsNullOrEmpty(status.ToString()))
            {
                filterParams.Add(new FilterExtensions.FilterParams
                {
                    ColumnName = "Status",
                    FilterValue = status.ToString(),
                    FilterOption = FilterExtensions.FilterOptions.IsEqualTo
                });

            }
            if (!string.IsNullOrEmpty(type.ToString()))
            {
                filterParams.Add(new FilterExtensions.FilterParams
                {
                    ColumnName = "Status",
                    FilterValue = type.ToString(),
                    FilterOption = FilterExtensions.FilterOptions.IsEqualTo
                });

            }
            return filterParams;
        }

        public async Task<TransactionHis> GetByIdAsync(int id)
        {
            var entity = await _transactionHis.Query(u => u.Id.Equals(id)).FirstOrDefaultAsync();
            return entity;
        }

        public async Task<int> GetTotalTransaction()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);

            return _transactionHis.GetAll().Where(u => u.UserId == user.Id).Count();
        }

        public async Task<List<TranserHisViewModel>> ListTranHistByUser(int pageIndex, int pageSize)
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);

            var query = _transactionHis.GetAll()
                .Where(u => u.UserId == user.Id)
                .OrderByDescending(u => u.CreatedDate)
                .Select(x => _mapper.Map<TranserHisViewModel>(x))
                .AsQueryable();
            return PageList<TranserHisViewModel>.Create(query, pageIndex, pageSize, false);
        }

        public decimal GetSumTotal()
        {
            return  _transactionHis.GetAll().Sum(u=> u.Credit);
        }
    }
}
