using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity.IdentityAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusSystem.Data.Implements
{
    public class UserRepository : BaseRepository<User>,IUserRepository
    {
        public UserRepository(BusSystemDbContext context) : base(context)
        {

        }

        public User GetByUserName(string username)
        {
            return _dbContext.Users.Where(u => u.UserName == username).FirstOrDefault();
        }

        public User GetUserWallet(User user)
        {
            return (User)_dbContext.Users.Include(u => u.Wallet).Where(p => p.Wallet.UserId == user.Id).FirstOrDefault() ;
        }
    }
}
