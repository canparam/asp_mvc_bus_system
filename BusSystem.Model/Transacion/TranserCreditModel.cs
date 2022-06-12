using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusSystem.Model.Transacion
{
    public class TranserCreditModel
    {
        [Required(ErrorMessage = "UserId is required")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Credit is required")]
        [Range(0.01, 100000000, ErrorMessage = "Credit must be greter than zero !")]
        public decimal Credit { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
    }
}
