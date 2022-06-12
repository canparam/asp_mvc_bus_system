using BusSystem.Data.Implements;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Services.Implements;
using BusSystem.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Configuration
{
    public class Dependency
    {
        public static void Configuration(IServiceCollection services)
        {
            // unitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // role
            services.AddScoped<IRoleRepository, RoleRepository>();
            //user
            services.AddScoped<IUserRepository, UserRepository>();
            // wallet
            services.AddScoped<IWalletRepository, WalletRepository>();
            // transac
            services.AddScoped<ITransactionHisRepository, TransactionHisRepository>();
            //bus
            services.AddScoped<IBusRepository, BusRepository>();
            services.AddScoped<IScheduleRepository, ScheduleRepository>();
            services.AddScoped<ITimeScheduleRepository, TimeScheduleRepository>();
            services.AddScoped<IBusScheduleRepository, BusScheduleRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();



            // services
            //role
            services.AddScoped<IRoleService, RoleService>();
            // user
            services.AddScoped<IUserService, UserService>();
            // wallet
            services.AddScoped<IWalletService, WalletService>();
            services.AddScoped<ITransactionHisService, TransactionHisService>();
            services.AddScoped<IBusService, BusService>();
            services.AddScoped<IScheduleService, ScheduleService>();
            services.AddScoped<IBusScheduleService, BusScheduleService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
