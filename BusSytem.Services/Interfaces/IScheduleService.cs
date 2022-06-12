using BusSystem.Entity;
using BusSystem.Model.Schedule;
using BusSystem.Model.TimeSchedule;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Interfaces
{
    public interface IScheduleService
    {
        Task<Schedule> CreateSchedule(Schedule schedule);
        List<ScheduleViewModel> List(int pageIndex, int pageSize, int? status, bool noPaging = false);
        List<TimeScheduleViewModel> ListTime(int pageIndex, int pageSize, int? scheduleId, bool noPaging = false);
        bool UpdateSch(Schedule schedule);
        Schedule GetById(int id);

        Task<TimeSchedule> CreateTimeSchedule(TimeSchedule timeSchedule);

        TimeSchedule GetTimeScheduleById(int id);

        bool RemoveTimeSchedule(TimeSchedule timeSchedule);
    }
}
