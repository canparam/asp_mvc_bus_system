using AutoMapper;
using BusSystem.Data.Enum;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using BusSystem.Model.Customer;
using BusSystem.Services.Interfaces;
using BusSytem.Services.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Implements
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CustomerService> _logger;
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper, IUnitOfWork unitOfWork, ILogger<CustomerService> logger)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                await _customerRepository.InsertAsync(customer);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return customer;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return null;
            }
        }

        public Customer GetFirstByPhone(string phone)
        {
            var result = _customerRepository.GetAll().Where(u => u.Phone.Contains(phone));
            return result.FirstOrDefault();
        }

        public int GetTotalCustomer()
        {
            return _customerRepository.GetAll().Count();
        }

        public List<CustomerViewModel> List(int page, int pageSize, bool noPaging = false)
        {
            var query = _customerRepository.GetAll()
              .Where(b => b.IsDel == (int)IsDel.ACTIVE)
              .OrderByDescending(e => e.CreatedDate)
              .Select(x => _mapper.Map<CustomerViewModel>(x));
            return PageList<CustomerViewModel>.Create(query, page, pageSize, noPaging);
        }

        public List<CustomerViewModel> ListTest(int page, int pageSize, bool noPaging = false)
        {
            var query = _customerRepository.GetAll()
              .Where(b => b.IsDel == (int)IsDel.ACTIVE)
              .Include(b => b.Orders)
              .Select(x => _mapper.Map<CustomerViewModel>(x));
            return PageList<CustomerViewModel>.Create(query, page, pageSize, noPaging);
        }

        public bool UpdateCustomer(Customer customer)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _customerRepository.Update(customer);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return false;
            }
        }
    }
}
