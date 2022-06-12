using AutoMapper;
using BusSystem.Data.Enum;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity;
using BusSystem.Model.Bus;
using BusSystem.Services.Extensions;
using BusSystem.Services.Interfaces;
using BusSytem.Services.Implements;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusSystem.Services.Implements
{
    public class BusService : IBusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBusRepository _busRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        public BusService(IUnitOfWork unitOfWork, IBusRepository busRepository, IMapper mapper, ILogger<BusService> logger)
        {
            _unitOfWork = unitOfWork;
            _busRepository = busRepository;
            _mapper = mapper;
            _logger = logger;
        }
        public Bus CreateBus(Bus bus)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _busRepository.InsertAsync(bus);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return bus;
            }
            catch
            {
                dbTransaction.Rollback();
                return null;
            }
        }

        public Bus FindById(int id)
        {
            return _busRepository.GetById(id);
        }

        public List<BusViewModel> List(int pageIndex, int pageSize, int? status, bool noPaging = false)
        {
            var filter = FilterParams(status);
            var query = _busRepository.GetAll()
              .Where(b => b.IsDel == (int)IsDel.ACTIVE)
              .Where(b => string.IsNullOrEmpty(status.ToString()) ? true : b.Status.Equals(status))
              .OrderByDescending(s => s.CreatedDate)
              .Select(x => _mapper.Map<BusViewModel>(x));
            return PageList<BusViewModel>.Create(query, pageIndex, pageSize, noPaging);
        }

        public bool UpdateBus(Bus bus)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _busRepository.Update(bus);
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

        public static List<FilterExtensions.FilterParams> FilterParams(int? status)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();
            if (!string.IsNullOrEmpty(status.ToString()))
            {
                filterParams.Add(new FilterExtensions.FilterParams
                {
                    ColumnName = "Status",
                    FilterValue = status.ToString(),
                    FilterOption = FilterExtensions.FilterOptions.IsEqualTo
                });

            }
            return filterParams;
        }
    }
}
