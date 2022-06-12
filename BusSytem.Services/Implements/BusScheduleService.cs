using AutoMapper;
using BusSystem.Data.Enum;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using BusSystem.Model.BusSchedule;
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
    public class BusScheduleService : IBusScheduleService
    {
        private readonly IBusScheduleRepository _busScheduleRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;
        public BusScheduleService(IBusScheduleRepository busScheduleRepository, IMapper mapper, ILogger<BusScheduleService> logger, IUnitOfWork unitOfWork)
        {
            _busScheduleRepository = busScheduleRepository;
            _mapper = mapper;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public async Task<BusSchedule> CeateBusSchedule(BusSchedule busSchedule)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                await _busScheduleRepository.InsertAsync(busSchedule);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return busSchedule;
            }
            catch
            {
                dbTransaction.Rollback();
                return null;
            }
        }

        public List<BusScheduleViewModel> List(int pageIndex, int pageSize,string BusName, int? status, bool noPaging = false)
        {
            var filter = FilterParams(BusName, status);
            var query = _busScheduleRepository.GetAll()
              .Where(b => b.IsDel == (int)IsDel.ACTIVE)
              .Include(u => u.TimeSchedule)
              .ThenInclude(time => time.Schedule)
              .Include(b =>b.Orders.Where(o => o.Status == (int)OrderStatus.ACTIVE).Where(o => o.IsDel == (int)IsDel.ACTIVE))
              .Include(u => u.Bus)
              .AsEnumerable().Select(x => _mapper.Map<BusScheduleViewModel>(x))
              .AsEnumerable().FilteredData(filter)
              .AsQueryable()
              .OrderByDescending(s => s.CreatedDate);
            return PageList<BusScheduleViewModel>.Create(query, pageIndex, pageSize, noPaging);
        }
        public static List<FilterExtensions.FilterParams> FilterParams( string BusName, int? status)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();
            if (!string.IsNullOrEmpty(BusName))
            {
                filterParams.Add(new FilterExtensions.FilterParams
                {
                    ColumnName = "BusName",
                    FilterValue = BusName,
                    FilterOption = FilterExtensions.FilterOptions.Contains
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

        public BusSchedule GetById(int id)
        {
            return _busScheduleRepository.GetById(id);
        }

        public bool UpdateBusSche(BusSchedule busSchedule)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _busScheduleRepository.Update(busSchedule);
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

        public BusScheduleViewModel GetFirstViewModelById(int id)
        {
            var query = _busScheduleRepository.GetAll()
              .Where(b => b.Id == id)
              .Include(u => u.TimeSchedule)
              .ThenInclude(time => time.Schedule)
              .Include(b => b.Orders.Where(o => o.Status == (int)OrderStatus.ACTIVE).Where(o => o.IsDel == (int)IsDel.ACTIVE))
              .Include(u => u.Bus)
              .AsEnumerable().Select(x => _mapper.Map<BusScheduleViewModel>(x))
              .AsQueryable();
            return query.FirstOrDefault();
        }

        public List<BusScheduleViewModel> ListScheduleActive(int pageIndex, int pageSize, BusScheduleSearchModel model)
        {
            //var filter = FilterParams(BusName, status);
            var p = model.Bus.Length > 0 ? true : false;

            var now = DateTime.Now;
            var query = _busScheduleRepository.GetAll()
              .Where(b => b.IsDel == (int)IsDel.ACTIVE)
              .Include(u => u.TimeSchedule)
              .ThenInclude(time => time.Schedule)
              .Where(u => string.IsNullOrEmpty(model.From) ? true : u.TimeSchedule.Schedule.From.Contains(model.From))
              .Where(u => string.IsNullOrEmpty(model.To) ? true : u.TimeSchedule.Schedule.To.Contains(model.To))
              .Include(b => b.Orders.Where(o => o.Status == (int)OrderStatus.ACTIVE).Where(o => o.IsDel == (int)IsDel.ACTIVE))
              .Include(u => u.Bus)
              .Where(b => model.Bus.Length <= 0 ? true : model.Bus.Contains(b.Bus.Id))
              .Where(u => u.TimeSchedule.StartTime > now)
              .Where(u => string.IsNullOrEmpty(model.StartTime.ToString()) ? true : u.TimeSchedule.StartTime >= model.StartTime && u.TimeSchedule.StartTime <= model.EndTime)
              .OrderByDescending(s => s.CreatedDate)
              .Select(x => _mapper.Map<BusScheduleViewModel>(x))
              //.AsEnumerable().FilteredData(filter)
              .AsQueryable();
              
            return PageList<BusScheduleViewModel>.Create(query, pageIndex, pageSize, false);
        }
    }
}
