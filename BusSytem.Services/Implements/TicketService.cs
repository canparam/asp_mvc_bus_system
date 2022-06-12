using AutoMapper;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using BusSystem.Model.Ticket;
using BusSystem.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Implements
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<TicketService> _logger;
        private readonly IMapper _mapper;
        public TicketService(ITicketRepository ticketRepository, IUnitOfWork unitOfWork, ILogger<TicketService> logger, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<Ticket> CreateTicket(Ticket ticket)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                await _ticketRepository.InsertAsync(ticket);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return ticket;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return null;
            }
        }

        public string GenCode()
        {
            var last = GetLatest();
            string code = "VBus_" + (last == null ? "0" : (last.Id + 1).ToString());
            return code;
        }

        public Ticket GetByOrderId(int id)
        {
            return _ticketRepository.GetAll().Where(u => u.OrderId == id).FirstOrDefault();
        }

        public Ticket GetLatest()
        {
            return _ticketRepository.GetAll().OrderByDescending(t => t.CreatedDate).FirstOrDefault();
        }

        public TicketDetailModel GetTicketDetailByOrderId(int id)
        {
            var query = _ticketRepository.GetAll()
                .Where(u => u.OrderId == id)
                .Include(u => u.Order)
                .ThenInclude(o => o.BusSchedule)
                .ThenInclude(bus => bus.TimeSchedule)
                .ThenInclude(bus => bus.Schedule)
                .Select(x => _mapper.Map<TicketDetailModel>(x))
                .AsQueryable();
            return query.FirstOrDefault();
            ;
        }
    }
}
