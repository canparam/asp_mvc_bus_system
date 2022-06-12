using BusSystem.Entity;
using BusSystem.Model.Ticket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Interfaces
{
    public interface ITicketService
    {
        Ticket GetLatest();
        string GenCode();

        Ticket GetByOrderId(int id);
        Task<Ticket> CreateTicket(Ticket ticket);

        TicketDetailModel GetTicketDetailByOrderId(int id);
    }
   
}
