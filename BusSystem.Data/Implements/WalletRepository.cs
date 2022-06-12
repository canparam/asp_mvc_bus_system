using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusSystem.Data.Implements
{
    public class WalletRepository : BaseRepository<Wallet>, IWalletRepository
    {
        public WalletRepository(BusSystemDbContext context) : base(context)
        {

        }

        public Wallet FindByUserId(string id)
        {
            return _dbContext.Wallets.Where(w => w.UserId == id).FirstOrDefault();
        }
    }
}
