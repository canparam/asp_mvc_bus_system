using BusSystem.Data.Repository;
using BusSystem.Entity.IdentityAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Data.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetUserWallet(User user);
        User GetByUserName(string username);
    }
}
