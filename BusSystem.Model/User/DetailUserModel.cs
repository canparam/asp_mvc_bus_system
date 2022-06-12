using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.User
{
    public class DetailUserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public int Type { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Code { get; set; }
        public string Logo { get; set; }
    }
}
