using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.BusSchedule
{
    public class BusScheduleViewModel
    {
        public int? Id { get; set; }
        public int? Status { get; set; }
        public int? BusId { get; set; }
        public int? TimeScheduleId { get; set; }
        public int? ScheduleId { get; set; }

        public decimal? PriceTicket { get; set; }
        public DateTime? StartTime { get; set; }
        public string BusName { get; set; }
        public int? NumberPassengers { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int? TotalTicket { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
