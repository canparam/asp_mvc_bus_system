using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusSystem.Model.User
{
    public class CreatePartnerModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "FullName is required")]
        public string FullName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]

        public string Password { get; set; }
        [Required(ErrorMessage = "Address is required")]

        public string Address { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required")]

        public string PhoneNumber { get; set; }

    }
}
