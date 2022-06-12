using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DbSet<T> Dbset;
        protected readonly BusSystemDbContext _dbContext;
        public BaseRepository(BusSystemDbContext context)
        {
            _dbContext = context;
            Dbset = context.Set<T>();
        }

        public bool Delete(T entity)
        {
            try
            {
                var entry = _dbContext.Entry(entity);
                entry.State = EntityState.Deleted;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public IQueryable<T> GetAll()
        {
            return Dbset.AsQueryable();
        }

        public T GetById(int id)
        {
            return Dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return Dbset.Find(id);
        }
        public T Insert(T entity)
        {
            Dbset.Add(entity);

            return entity;
        }

        public async Task<T> InsertAsync(T entity)
        {
            await Dbset.AddAsync(entity);

            return entity;
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> filter)
        {
            return Dbset.Where(filter);
        }

        public T Update(T entity)
        {
            var dbEntityEntry = _dbContext.Entry(entity);
            dbEntityEntry.State = EntityState.Modified;
            return entity;
        }
        
        public void CascadeDelete(T entity)
        {
            _dbContext.Remove(entity);

        }
    }
}
