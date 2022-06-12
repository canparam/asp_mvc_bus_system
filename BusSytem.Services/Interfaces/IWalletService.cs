using BusSystem.Entity;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.Transacion;
using BusSystem.Model.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Interfaces
{
    public interface IWalletService
    {
        Task<bool> CreateUserWalletAsync( User user);
        Wallet GetUserWallet(User user);

        Task<decimal> UserAmount();

        Task<bool> TransactionCredit(User user, TranserCreditModel model);

        bool UpdateWallet(Wallet wallet);
    }
}
