using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.BusSchedule
{
    public class BusScheduleSearchModel
    {
        public string From { get; set; }
        public string To { get; set; }

        public int[] Bus { get; set; }
        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }
    }
}
