using AutoMapper;
using BusSystem.Data.Enum;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.User;
using BusSystem.Services.Extensions;
using BusSystem.Services.Interfaces;
using BusSytem.Services.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Implements
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public UserService(IUserRepository userRepository, IMapper mapper, IUnitOfWork unitOfWork, ILogger<User> logger)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public async Task<bool> CreateUserAsync(User entity)
        {
            var dbtransaction = _unitOfWork.BeginTransaction();
            try
            {
                await _userRepository.InsertAsync(entity);
                dbtransaction.Commit();
                return true;
            }
            catch
            {
                dbtransaction.Rollback();
                return false;
            }
        }

        public bool GetByCode(string code)
        {
            throw new NotImplementedException();
        }

        public User GetById(string id)
        {
            var user = _userRepository.GetById(id);
            return user;
        }

        public List<PartnerUserViewModel> ListPartner(int pageIndex, int pageSize, string username,string email, int? status)
        {
            var filter = FilterParams(username,email, status);
            var query = _userRepository.GetAll()
                .Where(u => u.IsDel == (int)IsDel.ACTIVE)
                .Where(u => u.Type == (int)UserType.PARTNER)
                .Include(x => x.Wallet)
                .Where(u => string.IsNullOrEmpty(username) ? true : u.UserName.Contains(username))
                .Where(u => string.IsNullOrEmpty(email) ? true : u.Email.Equals(email))
                .Where(u => string.IsNullOrEmpty(status.ToString()) ? true : u.Status.Equals(status))
                .OrderByDescending(s => s.CreatedDate)
                .Select(x => _mapper.Map<PartnerUserViewModel>(x))
                .AsQueryable();
            return PageList<PartnerUserViewModel>.Create(query, pageIndex, pageSize, true);

        }

        public bool RemoveUser(string id)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var user = _userRepository.GetById(id);
                if (user == null)
                {
                    return false;
                }
                _userRepository.Delete(user);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch(Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return false;
            }
        }

        public bool UpdateUser(User entity)
        {
            throw new NotImplementedException();
        }

        public User UserWallet(User user)
        {
            return _userRepository.GetUserWallet(user);
        }

        public bool RemovePartner(string id)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var user = _userRepository.GetById(id);
                if (user == null)
                {
                    return false;
                }
                user.IsDel = (int)IsDel.DEL;

                _userRepository.Update(user);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return false;
            }
        }

        public static List<FilterExtensions.FilterParams> FilterParams(string username, string email, int? status)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();
            if (!string.IsNullOrEmpty(username))
            {
                filterParams.Add(new FilterExtensions.FilterParams
                {
                    ColumnName = "UserName",
                    FilterValue = username,
                    FilterOption = FilterExtensions.FilterOptions.Contains
                });
            }
            if (!string.IsNullOrEmpty(email))
            {
                filterParams.Add(new FilterExtensions.FilterParams
                {
                    ColumnName = "Email",
                    FilterValue = email,
                    FilterOption = FilterExtensions.FilterOptions.IsEqualTo
                });
            }
            if (!string.IsNullOrEmpty(status.ToString()))
            {
                filterParams.Add(new FilterExtensions.FilterParams
                {
                    ColumnName = "Status",
                    FilterValue = status.ToString(),
                    FilterOption = FilterExtensions.FilterOptions.IsEqualTo
                });

            }
            return filterParams;
        }

        public async Task<User> GetByIdAsync(string id)
        {
            var entity =  await _userRepository.Query(u => u.Id.Equals(id)).FirstOrDefaultAsync();
            return entity;
        }

        public int GetTotalPartner()
        {
            return _userRepository.GetAll().Where(u => u.Type == 1).Count();
        }

        public List<PartnerUserViewModel> TopPartner(int size = 10)
        {
            var query = _userRepository.GetAll()
                .Where(u => u.IsDel == (int)IsDel.ACTIVE)
                .Where(u => u.Type == (int)UserType.PARTNER)
                .Include(x => x.Wallet)
                .OrderByDescending(s => s.Wallet.Amount)
                .Select(x => _mapper.Map<PartnerUserViewModel>(x))
                .AsQueryable();
            return PageList<PartnerUserViewModel>.Create(query, 1, size, false);

        }
    }
}
