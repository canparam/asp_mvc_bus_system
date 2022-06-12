using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.Order
{
    public class OrderViewModel
    {
        public int? Id { get; set; }
        public decimal? Amount { get; set; }
        public int? Discount { get; set; }
        public int? Status { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public decimal? Total { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string UserName { get; set; }
    }
}
