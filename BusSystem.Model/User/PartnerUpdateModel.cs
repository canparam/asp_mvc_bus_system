using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusSystem.Model.User
{
    public class PartnerUpdateModel
    {
        public string Password { get; set; }
        [Required(ErrorMessage = "Address is required")]

        public string Address { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required")]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "FullName is required")]
        public string FullName { get; set; }

        public int Status { get; set; }

    }
}
