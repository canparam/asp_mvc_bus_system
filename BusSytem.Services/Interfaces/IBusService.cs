using BusSystem.Entity;
using BusSystem.Model.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Services.Interfaces
{
    public interface IBusService
    {
        Bus CreateBus(Bus bus);
        Bus FindById(int id);

        bool UpdateBus(Bus bus);

        List<BusViewModel> List(int pageIndex, int pageSize, int? status, bool noPaging = false);

    }
}
