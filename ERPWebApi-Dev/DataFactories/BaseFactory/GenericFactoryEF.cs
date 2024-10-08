using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataFactories.BaseFactory
{
    public class GenericFactoryEF<C, T> : IGenericFactoryEF<T> where T : class where C : DbContext, new()
    {
        private C Context = new C();
        private DbSet<T> _dbset;

        protected C _dbctx
        {
            get { return Context; }
            set { Context = value; }
        }

        public GenericFactoryEF()
        {
            _dbset = _dbctx.Set<T>();
        }

        #region ===========readonly=========

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        //public async Task<T> GetById(T entity)
        //{
        //    return await _dbset.FindAsync(entity);
        //}

        public async Task<T> GetById(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.Where(predicate).ToListAsync();
        }        

        public async Task<bool> HasData(Expression<Func<T, bool>> predicate)
        {
            return await FindBy(predicate) == null ? false : true;
        }

        //public int getMaxVal_int(string strColName, string strTblName)
        //{
        //    string sql = string.Format("SELECT ISNULL(MAX([{0}]),0) AS [{0}] FROM {1}", strColName, strTblName);
        //    int max = _dbctx.Database.SqlQuery<int>(sql).SingleOrDefault();
        //    return Convert.ToInt16(max + 1);
        //}

        //public Int64 getMaxVal_int64(string strColName, string strTblName)
        //{
        //    string sql = string.Format("SELECT ISNULL(MAX([{0}]),0) AS [{0}] FROM {1}", strColName, strTblName);
        //    Int64 max = _dbctx.Database.SqlQuery<Int64>(sql).SingleOrDefault();
        //    return Convert.ToInt64(max + 1);
        //}

        #endregion

        #region ======crud operations=======
        public virtual void InsertAsync(T entity)
        {
            _dbset.Add(entity);
        }

        public virtual void InsertListAsync(IEnumerable<T> entities)
        {
            _dbset.AddRange(entities);
        }

        public virtual void UpdateAsync(T entity)
        {
            _dbctx.Entry(entity).State = EntityState.Modified;
        }

        public virtual void DeleteAsync(T entity)
        {
            _dbset.Remove(entity);
        }

        public virtual void DeleteListAsync(IEnumerable<T> entities)
        {
            _dbset.RemoveRange(entities);
        }

        public virtual void DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> list = _dbset.Where(predicate);
            foreach (var entity in list)
            {
                _dbset.Remove(entity);
            }
        }

        public async Task SaveAsync()
        {
            await _dbctx.SaveChangesAsync();
        }

        #endregion

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {

            if (!this.disposed)
                if (disposing)
                    _dbctx.Dispose();
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
