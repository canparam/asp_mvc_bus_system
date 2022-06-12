using BusSystem.Entity;
using BusSystem.Model.BusSchedule;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Interfaces
{
    public interface IBusScheduleService
    {
        Task<BusSchedule> CeateBusSchedule(BusSchedule busSchedule);
        List<BusScheduleViewModel> List(int pageIndex, int pageSize,  string BusName, int? status, bool noPaging = false);
        BusSchedule GetById(int id);
        BusScheduleViewModel GetFirstViewModelById(int id);
        bool UpdateBusSche(BusSchedule busSchedule);

        List<BusScheduleViewModel> ListScheduleActive(int pageIndex, int pageSize, BusScheduleSearchModel model);
    }
}
