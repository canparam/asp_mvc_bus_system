using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity.IdentityAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Data.Implements
{
    public class RoleRepository : BaseRepository<Role>,IRoleRepository
    {
        public RoleRepository(BusSystemDbContext context): base(context)
        {

        }
    }
}
