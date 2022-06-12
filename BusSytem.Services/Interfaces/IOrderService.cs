using BusSystem.Entity;
using BusSystem.Model;
using BusSystem.Model.BusSchedule;
using BusSystem.Model.Order;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderViewModel>> ListOrderByUser(int pageIndex, int pageSize);

        List<OrderViewModel> ListOrder(int pageIndex, int PageSize, OrderSearchModel model);
        Task<Order> CreateOrderAsync(BusScheduleViewModel busSchedule, CreateOrderModel createOrderModel);
        Order CreateOder(Order order);

        Task<OrderDetailViewModel> OrderDetail(int id);

        Task<int> TotalOrder();

        int GetTotalTicketByBusScheId(int id);

        decimal GetTotalOrder();

        Task<bool> CancelOder(int id, decimal amount, string message);

        Dictionary<string, List<Chart>> GetDataChart();
    }
}
