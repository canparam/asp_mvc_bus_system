using AutoMapper;
using BusSystem.Data.Interfaces;
using BusSystem.Data.Repository;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.Role;
using BusSystem.Services.Interfaces;
using BusSytem.Services.Implements;
using BusSytem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Services.Implements
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public RoleService(IRoleRepository roleRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public List<RoleViewModel> List()
        {
            return _roleRepository.GetAll()
                .AsEnumerable().Select(x => _mapper.Map<RoleViewModel>(x))
                .AsQueryable()
                .OrderByDescending(s => s.CreatedDate)
                .ToList();
        }
        public List<RoleViewModel> List(int pageIndex, int pageSize = 10)
        {
            var query = _roleRepository.GetAll()
                .AsEnumerable().Select(x => _mapper.Map<RoleViewModel>(x))
                .AsQueryable().OrderByDescending(s => s.CreatedDate);

            return PageList<RoleViewModel>.Create(query, pageIndex, pageSize, true);
        }
        
        public async Task<bool> CreateRole(Role entity)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                await _roleRepository.InsertAsync(entity);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch 
            {
                dbTransaction.Rollback();
                return false;
            }
        }

        public bool GetByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Role GetById(string id)
        {
            throw new NotImplementedException();
        }


        public bool RemoveRole(string id)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var role = _roleRepository.GetById(id);
                if (role == null)
                {
                    return false;
                }
                _roleRepository.Delete(role);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch
            {
                dbTransaction.Rollback();
                return false;
            }
        }

        public bool UpdateRole(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
