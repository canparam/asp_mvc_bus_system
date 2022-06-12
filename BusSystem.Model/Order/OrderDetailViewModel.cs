using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.Order
{
    public class OrderDetailViewModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime StartTime { get; set; }
        public string BusName { get; set; }

        public decimal? Amount { get; set; }
        public decimal? Total { get; set; }

        public int? Discount { get; set; }

        public int? OrderStatus { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }

        public string Code { get; set; }

        public int? TicketStatus { get; set; }
        public DateTime? OrderCreateDate { get; set; }
    }
}
