using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using BusSystem.Entity.IdentityAccess;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Data.Seed
{
    public class AdminSeeding
    {

        private readonly UserManager<User> _userManager;
        private readonly IWalletRepository _walleRepository;
        private readonly IUnitOfWork _unitOfWork;
        public AdminSeeding(UserManager<User> userManager, IWalletRepository walletRepository, IUnitOfWork unitOfWork)
        {

            _userManager = userManager;
            _walleRepository = walletRepository;
            _unitOfWork = unitOfWork;

        }

        public async Task SeddingAdmin()
        {
            var user = new User()
            {
                Email = "admin@gmail.com",
                UserName = "admin",
                Type =  0
            };
            var result = await _userManager.CreateAsync(user, "Admin@123");

            var wallet = new Wallet()
            {
                Id = 1,
                Amount = 100,
                UserId = user.Id
            };
            _walleRepository.Insert(wallet);
            _unitOfWork.Complete();
        }
    }
}
