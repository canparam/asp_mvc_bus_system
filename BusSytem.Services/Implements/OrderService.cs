using AutoMapper;
using BusSystem.Data.Enum;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Model;
using BusSystem.Model.BusSchedule;
using BusSystem.Model.Order;
using BusSystem.Model.Transacion;
using BusSystem.Services.Interfaces;
using BusSytem.Services.Implements;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Implements
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<OrderService> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICustomerRepository _customerRepository;
        private readonly IWalletRepository _walletRepository;
        private readonly ITransactionHisRepository _transactionHisRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;

        private readonly ICustomerService _customerService;
        private readonly UserManager<User> _userManager;
        private readonly IOrderRepository _orderRepository;
        private readonly IWalletService _walletService;
        private readonly ITicketService _ticketService;

        private readonly IMapper _mapper;

        public OrderService(ITransactionHisService transactionHisService, ITicketService ticketService,
            IWalletService walletService,
            IOrderRepository orderRepository, UserManager<User> userManager, ICustomerService customerService,
            IUnitOfWork unitOfWork, ILogger<OrderService> logger,
            IHttpContextAccessor httpContextAccessor, ICustomerRepository customerRepository, IWalletRepository walletRepository,
            ITransactionHisRepository transactionHisRepository, ITicketRepository ticketRepository, IMapper mapper, IOrderDetailRepository orderDetailRepository)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _customerRepository = customerRepository;
            _walletRepository = walletRepository;
            _transactionHisRepository = transactionHisRepository;
            _ticketRepository = ticketRepository;

            _customerService = customerService;
            _userManager = userManager;
            _orderRepository = orderRepository;
            _walletService = walletService;
            _ticketService = ticketService;
            _mapper = mapper;
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<bool> CancelOder(int id, decimal amount, string message)
        {
            var order = _orderRepository.GetById(id);
            if (order == null)
            {
                return false;
            }
            User user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            order.Status = (int)OrderStatus.INACTIVE;
            _orderRepository.Update(order);
            _unitOfWork.Complete();

            var ticket = _ticketRepository.GetAll().Where(t => t.OrderId == order.Id).FirstOrDefault();
            ticket.Status = (int)TicketStatus.CANCEL;
            _ticketRepository.Update(ticket);

            var transer = new TranserCreditModel()
            {
                UserId = user.Id,
                Credit = amount,
                Status = (int)Data.Enum.TransactionStatus.PLUS,
                Type = (int)Data.Enum.TransactionType.REFUND,
                Message = message
            };
            var send = await _walletService.TransactionCredit(user, transer);
            if (send == true)
            {
                return true;
            }
            return false;

        }

        public Order CreateOder(Order order)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _orderRepository.Insert(order);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return order;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return null;
            }
        }

        public async Task<Order> CreateOrderAsync(BusScheduleViewModel busSchedule, CreateOrderModel createOrderModel)
        {

            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var custom = _customerService.GetFirstByPhone(createOrderModel.PhoneNumber);
                if (custom == null)
                {
                    custom = new Customer()
                    {
                        FullName = createOrderModel.FullName,
                        Email = createOrderModel.Email,
                        Phone = createOrderModel.PhoneNumber,
                        Address = createOrderModel.Address,
                        Birthday = createOrderModel.Birthday,
                        CreatedDate = DateTime.Now
                    };
                    custom = await _customerRepository.InsertAsync(custom);
                    _unitOfWork.Complete();
                }
                else
                {
                    custom.FullName = createOrderModel.FullName;
                    custom.Email = createOrderModel.Email;
                    custom.Phone = createOrderModel.PhoneNumber;
                    custom.Address = createOrderModel.Address;
                    custom.Birthday = createOrderModel.Birthday;
                    _customerRepository.Update(custom);
                }
                var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);


                var wallet = _walletService.GetUserWallet(user);

                wallet.Amount = wallet.Amount - createOrderModel.Amount;

                _walletRepository.Update(wallet);

                var hisTransaction = new TransactionHis()
                {
                    Credit = createOrderModel.Amount,
                    UserId = user.Id,
                    Status = (int)Data.Enum.TransactionStatus.SUB,
                    Type = (int)Data.Enum.TransactionType.BUY,
                    CreatedBy = user.UserName,
                    CreatedDate = DateTime.Now,
                    Message = "Payment buy ticket"
                };
                await _transactionHisRepository.InsertAsync(hisTransaction);
                _unitOfWork.Complete();

                var oder = new Order()
                {
                    UserId = user.Id,
                    Amount = createOrderModel.Amount,
                    Total = (decimal)busSchedule.PriceTicket,
                    Status = 0,
                    Discount = createOrderModel.Discount,
                    CustomerId = custom.Id,
                    CreatedDate = DateTime.Now,
                    BusCheduleId = (int)busSchedule.Id,
                    TransactionId = hisTransaction.Id
                };
                var od = await _orderRepository.InsertAsync(oder);
                _unitOfWork.Complete();

                //create order detail;
                var orderDetail = new OrderDetail()
                {
                    BusName = busSchedule.BusName,
                    From = busSchedule.From,
                    To = busSchedule.To,
                    Price = (decimal)busSchedule.PriceTicket,
                    OrderId = od.Id,
                    StartTime = (DateTime)busSchedule.StartTime,
                    CreatedDate = DateTime.Now
                };
                await _orderDetailRepository.InsertAsync(orderDetail);


                

               

                var ticket = new Ticket()
                {
                    Code = _ticketService.GenCode(),
                    Status = 0,
                    OrderId = od.Id,
                    CreatedDate = DateTime.Now
                };

                await _ticketRepository.InsertAsync(ticket);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return od;

            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return null;
            }



        }

        public Dictionary<string, List<Chart>> GetDataChart()
        {
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var query = _orderRepository.GetAll()
                .Where(e => e.CreatedDate >= startDate)
                .Where(e => e.CreatedDate <= endDate)
                .Select(e => new
                {
                    e.Status,
                    CreateDate = e.CreatedDate.ToString("dd-MM-yyyy")
                }).ToList()
                .GroupBy(e => new
                {
                    e.Status,
                    e.CreateDate,

                }).Select(e => new Chart
                {
                    Count = e.Count(),
                    Status = e.Key.Status,
                    Date = e.Key.CreateDate,
                }).ToList();

            var dic = new Dictionary<string, List<Chart>>();
            dic.Add("seri1", new List<Chart>());
            dic.Add("seri2", new List<Chart>());
            while (startDate <= endDate)
            {
                dic["seri1"].Add(query.FirstOrDefault(x => x.Status == 0 && startDate.ToString("dd-MM-yyyy") == x.Date) ?? new Chart { 
                    Date = startDate.ToString("dd-MM-yyyy"),
                    Count = 0,
                    Status = 0
                });

                dic["seri2"].Add(query.FirstOrDefault(x => x.Status == 1 && startDate.ToString("dd-MM-yyyy") == x.Date) ?? new Chart
                {
                    Date = startDate.ToString("dd-MM-yyyy"),
                    Count = 0,
                    Status = 0
                });

                startDate = startDate.AddDays(1);
            }

            return dic;
        }

        public decimal GetTotalOrder()
        {
            return _orderRepository.GetAll().Count();
        }

        public int GetTotalTicketByBusScheId(int id)
        {
            return _orderRepository.GetAll().Where(u => u.BusCheduleId == id && u.Status == (int)OrderStatus.ACTIVE).Count();
        }

        public List<OrderViewModel> ListOrder(int pageIndex, int PageSize, OrderSearchModel model)
        {
            var query = _orderRepository.GetAll()
                .Where(u => u.IsDel == (int)IsDel.ACTIVE)
                .Include(x => x.User)
                .Where(u => string.IsNullOrEmpty(model.UserName) ? true : u.User.UserName.Contains(model.UserName))
                .OrderByDescending(s => s.CreatedDate)
                .Select(x => _mapper.Map<OrderViewModel>(x));
            return PageList<OrderViewModel>.Create(query, pageIndex, PageSize, false);
        }

        public async Task<List<OrderViewModel>> ListOrderByUser(int pageIndex, int pageSize)
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            var query = _orderRepository.GetAll()
                .Where(u => u.IsDel == (int)IsDel.ACTIVE)
                .Where(u => u.UserId == user.Id)
                .Include(x => x.Customer)
                .OrderByDescending(s => s.CreatedDate)
                .Select(x => _mapper.Map<OrderViewModel>(x))
                .AsQueryable();

            return PageList<OrderViewModel>.Create(query, pageIndex, pageSize, false);
        }

        public async Task<OrderDetailViewModel> OrderDetail(int id)
        {
            var query = _orderDetailRepository.GetAll()
                .Where(o => o.OrderId == id)
                .Include(o => o.Order)
                .ThenInclude(o => o.Customer)
                .Include(o => o.Order.Ticket)
                .Select(x => _mapper.Map<OrderDetailViewModel>(x));
            return await query.FirstOrDefaultAsync();
        }

        public async Task<int> TotalOrder()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);

            return _orderRepository.GetAll().Where(u => u.UserId == user.Id).Count();
        }
    }
}
