using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.User
{
    public class PartnerUserViewModel : BaseModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public decimal? Amount { get; set; }

        public int? Status { get; set; }

    }
    
    
}
