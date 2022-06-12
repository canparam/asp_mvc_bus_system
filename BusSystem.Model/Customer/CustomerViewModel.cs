using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.Customer
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }

        public int? TotalTicket { get; set; }

    }
}
