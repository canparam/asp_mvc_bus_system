using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.User;
using BusSystem.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Interfaces
{
    public interface IUserService
    {
        //List<RoleViewModel> List(int pageIndex, int pageSize);
        User GetById(string id);
        Task<User> GetByIdAsync(string id);
        bool GetByCode(string code);
        Task<bool> CreateUserAsync(User entity);
        bool UpdateUser(User entity);
        bool RemoveUser(string id);
        bool RemovePartner(string id);
        User UserWallet(User user);

        List<PartnerUserViewModel> ListPartner(int pageIndex, int pageSize, string username,string email, int? status);

        int GetTotalPartner();

        List<PartnerUserViewModel> TopPartner(int size = 10);
    }
}
