using BusSystem.Entity;
using BusSystem.Model.Customer;
using BusSystem.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerViewModel> List(int page, int pageSize, bool noPaging = false);
        Customer GetFirstByPhone(string phone);

        Task<Customer> CreateCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

        List<CustomerViewModel> ListTest(int page, int pageSize,bool noPaging = false);

        int GetTotalCustomer();
    }
}
