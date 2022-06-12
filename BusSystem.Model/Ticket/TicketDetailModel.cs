using BusSystem.Model.BusSchedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.Ticket
{
    public class TicketDetailModel
    {
        public string Code { get; set; }

        public string From { get; set; }
        public string To { get; set; }
        public DateTime? StartTime { get; set; }
        public int? Status { get; set; }

    }
}
