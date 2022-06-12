using AutoMapper;
using BusSystem.Data.Enum;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using BusSystem.Model.Schedule;
using BusSystem.Model.TimeSchedule;
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
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ITimeScheduleRepository _timeScheduleRepository;
        public ScheduleService(ITimeScheduleRepository timeScheduleRepository, IScheduleRepository scheduleRepository, IUnitOfWork unitOfWork, ILogger<ScheduleService> logger, IMapper mapper)
        {
            _scheduleRepository = scheduleRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _timeScheduleRepository = timeScheduleRepository;
        }
        public async Task<Schedule> CreateSchedule(Schedule schedule)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                await _scheduleRepository.InsertAsync(schedule);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return schedule;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return null;
            }
        }

        public async Task<TimeSchedule> CreateTimeSchedule(TimeSchedule timeSchedule)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                await _timeScheduleRepository.InsertAsync(timeSchedule);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return timeSchedule;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return null;
            }
        }

        public Schedule GetById(int id)
        {
            return _scheduleRepository.GetById(id);
        }

        public TimeSchedule GetTimeScheduleById(int id)
        {
            return _timeScheduleRepository.GetById(id);
        }

        public List<ScheduleViewModel> List(int pageIndex, int pageSize,int? status, bool noPaging = true)
        {
            var query = _scheduleRepository.GetAll()
                  .Include(u => u.TimeSchedules.Where(p => p.IsDel == (int)IsDel.ACTIVE))
                  .Where(b => b.IsDel == (int)IsDel.ACTIVE)
                  .Where(u => string.IsNullOrEmpty(status.ToString()) ? true : u.Status == status)
                  .OrderByDescending(s => s.CreatedDate)
                  .Select(x => _mapper.Map<ScheduleViewModel>(x));
            return PageList<ScheduleViewModel>.Create(query, pageIndex, pageSize, noPaging);
        }

        public List<TimeScheduleViewModel> ListTime(int pageIndex, int pageSize, int? scheduleId,  bool noPaging = false)
        {

            var query = _timeScheduleRepository.GetAll()
                .Where(u => string.IsNullOrEmpty(scheduleId.ToString()) ? true : u.ScheduleId == scheduleId)
                .Where(u => u.IsDel == (int)IsDel.ACTIVE)
                .OrderByDescending(s => s.CreatedDate)
                .Select(x => _mapper.Map<TimeScheduleViewModel>(x));
                
            return PageList<TimeScheduleViewModel>.Create(query, pageIndex, pageSize, noPaging);

        }

        public bool RemoveTimeSchedule(TimeSchedule timeSchedule)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                timeSchedule.IsDel = (int)IsDel.DEL;
                _timeScheduleRepository.Update(timeSchedule);
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

        public bool UpdateSch(Schedule schedule)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _scheduleRepository.Update(schedule);
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

        public static List<FilterExtensions.FilterParams> FilterParams(int? status)
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
            return filterParams;
        }
    }
}
