using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.BaseFactory
{
    public interface IGenericFactoryEF<T> : IDisposable where T : class
    {
        //Task<T> GetById(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate);
        Task<bool> HasData(Expression<Func<T, bool>> predicate);
        void InsertAsync(T entity);
        void InsertListAsync(IEnumerable<T> entity);
        void UpdateAsync(T entity);
        void DeleteAsync(T entity);
        void DeleteListAsync(IEnumerable<T> entity);
        void DeleteAsync(Expression<Func<T, bool>> predicate);
        Task SaveAsync();
    }
}
