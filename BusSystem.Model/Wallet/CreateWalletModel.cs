using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.Wallet
{
    public class CreateWalletModel : BaseModel
    {
        public string UserId { get; set; }
        public decimal Amount { get; set; }
    }
}
