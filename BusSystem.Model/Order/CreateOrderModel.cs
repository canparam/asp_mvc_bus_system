using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusSystem.Model.Order
{
    public class CreateOrderModel
    {
        [Required(ErrorMessage = "BusCheduleId is required")]
        public int BusCheduleId { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Birthday is required")]
        public DateTime Birthday { get; set; }
        [Required(ErrorMessage = "FullName is required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int Discount { get; set; }

        public decimal Amount { get; set; }
    }
}
