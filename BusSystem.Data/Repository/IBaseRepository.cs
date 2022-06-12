using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Data.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// Function use to get Object flow Id
        /// </summary>
        /// <param name="id">Primary key of Table current</param>
        /// <returns></returns>
        T GetById(int id);
        /// <summary>
        /// Get All list Object
        /// </summary>
        /// <returns></returns>
        T GetById(string id);

       
        IQueryable<T> GetAll();

        /// <summary>
        /// Function use to Insert Object 
        /// </summary>
        /// <param name="entity">Object is targer Update</param>
        /// <returns></returns>
        T Insert(T entity);

        Task<T> InsertAsync(T entity);

        /// <summary>
        /// Function use to Update Object 
        /// </summary>
        /// <param name="entity">Object is targer Update</param>
        /// <returns></returns>
        T Update(T entity);

        /// <summary>
        /// Function use to Remove Object in Database
        /// </summary>
        /// <param name="entity">Object is targer Update</param>
        /// <returns></returns>
        bool Delete(T entity);

        /// <summary>
        /// Function use in the case Query have condition
        /// </summary>
        /// <param name="filter">Condition of query</param>
        /// <returns></returns>
        /// 
        IQueryable<T> Query(Expression<Func<T, bool>> filter);
        void CascadeDelete(T entity);
    }
}
