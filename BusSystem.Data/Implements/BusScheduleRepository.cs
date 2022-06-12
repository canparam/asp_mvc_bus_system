using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Data.Implements
{
    public class BusScheduleRepository : BaseRepository<BusSchedule>, IBusScheduleRepository
    {
        public BusScheduleRepository(BusSystemDbContext context) : base(context)
        {

        }
    }
}
