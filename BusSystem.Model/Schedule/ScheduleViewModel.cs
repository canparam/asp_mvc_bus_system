using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.Schedule
{
    public class ScheduleViewModel
    {
        public int? Id { get; set; }
        public int? Status { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime? CreatedDate { get; set; }

        public int? CountTime { get; set; }
    }
}
