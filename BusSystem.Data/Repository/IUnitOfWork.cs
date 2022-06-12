using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Data.Repository
{
    public interface IUnitOfWork
    {
        Task<bool> CompleteAsync();

        bool Complete();

        IDbContextTransaction BeginTransaction();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BusSystemDbContext _context;

        public UnitOfWork(BusSystemDbContext context)
        {
            this._context = context;
        }


        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public bool Complete()
        {
            return _context.SaveChanges() > 0;
        }

        public async Task<bool> CompleteAsync()
        {
            return await this._context.SaveChangesAsync() > 0;
        }
    }
}
