using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Data.Implements
{
    public class TimeScheduleRepository : BaseRepository<TimeSchedule>, ITimeScheduleRepository
    {
        public TimeScheduleRepository(BusSystemDbContext context) : base(context)
        {

        }
    }
}
