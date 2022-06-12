using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.TimeSchedule
{
    public class TimeScheduleViewModel
    {
        public int? Id { get; set; }
        public int? ScheduleId { get; set; }
        public DateTime? StartTime { get; set; }
        public int? Status { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
