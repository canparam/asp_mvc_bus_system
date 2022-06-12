using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusSystem.Model.Bus
{
    public class CreateBusModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public int Status { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, 100000000, ErrorMessage = "Price must be greter than zero !")]
        public int Quantity { get; set; }
    }
}
