using AutoMapper;
using BusSystem.Entity;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.Bus;
using BusSystem.Model.BusSchedule;
using BusSystem.Model.Customer;
using BusSystem.Model.Order;
using BusSystem.Model.Role;
using BusSystem.Model.Schedule;
using BusSystem.Model.Ticket;
using BusSystem.Model.TimeSchedule;
using BusSystem.Model.Transacion;
using BusSystem.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Role, RoleViewModel>();
            CreateMap<User, PartnerUserViewModel>();
            CreateMap<TransactionHis, TranserHisViewModel>();
            CreateMap<Bus, BusViewModel>();
            CreateMap<Schedule, ScheduleViewModel>();
            CreateMap<TimeSchedule, TimeScheduleViewModel>();
            CreateMap<BusSchedule, BusScheduleViewModel>();
            CreateMap<Customer, CustomerViewModel>();
            CreateMap<Ticket, TicketDetailModel>();
            CreateMap<Order, OrderViewModel>();
            CreateMap<OrderDetail, OrderDetailViewModel>();
        }
    }
}
