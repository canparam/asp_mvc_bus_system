using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.Role;
using BusSytem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Interfaces
{
    public interface IRoleService
    {
        List<RoleViewModel> List(int pageIndex, int pageSize);
        Role GetById(string id);
        bool GetByCode(string code);
        Task<bool> CreateRole(Role entity);
        bool UpdateRole(Role entity);
        bool RemoveRole(string id);
        List<RoleViewModel> List();
    }
}
