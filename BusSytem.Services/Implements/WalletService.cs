using BusSystem.Data.Enum;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.Transacion;
using BusSystem.Model.User;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Implements
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<WalletService> _logger;
        private readonly ITransactionHisRepository _transactionHisRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public WalletService(ITransactionHisRepository transactionHis, IWalletRepository walletRepository, IUnitOfWork unitOfWork, UserManager<User> userManager, ILogger<WalletService> logger, IHttpContextAccessor httpContextAccessor)
        {
            _walletRepository = walletRepository;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _transactionHisRepository = transactionHis;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<bool> CreateUserWalletAsync(User user)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var wallet = new Wallet()
                {
                    UserId = user.Id,
                    Amount = 0,
                    CreatedDate = DateTime.Now
                };
                await _walletRepository.InsertAsync(wallet);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                dbTransaction.Rollback();
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public Wallet GetUserWallet(User user)
        {
            var wallet = _walletRepository.FindByUserId(user.Id);
            return wallet;
        }

        public async Task<bool> TransactionCredit(User user, TranserCreditModel model)
        {
            var dbTransacsion = _unitOfWork.BeginTransaction();
            try
            {
                var wallet = _walletRepository.FindByUserId(user.Id);
                if (wallet == null)
                {
                    return false;
                }
                if (model.Status == (int)Data.Enum.TransactionStatus.PLUS)
                {
                    wallet.Amount = (wallet.Amount + model.Credit);
                }
                else
                {
                    wallet.Amount = (wallet.Amount - model.Credit);
                }

                wallet.ModifiedDate = DateTime.UtcNow;

                wallet.ModifiedBy = _httpContextAccessor.HttpContext.User.Identity.Name;
                _walletRepository.Update(wallet);

                var hist = new TransactionHis()
                {
                    UserId = user.Id,
                    Credit = model.Credit,
                    CreatedDate = DateTime.Now,
                    CreatedBy = _httpContextAccessor.HttpContext.User.Identity.Name,
                    Type = model.Type,
                    Status = model.Status,
                    Message = model.Message
                };
                await _transactionHisRepository.InsertAsync(hist);
                _unitOfWork.Complete();
                dbTransacsion.Commit();
                return true;
            }
            catch (Exception e)
            {
                dbTransacsion.Rollback();
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public bool UpdateWallet(Wallet wallet)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _walletRepository.Update(wallet);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                dbTransaction.Rollback();
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public async Task<decimal> UserAmount()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            var result = _walletRepository.FindByUserId(user.Id);
            return result.Amount;
        }
    }
}
