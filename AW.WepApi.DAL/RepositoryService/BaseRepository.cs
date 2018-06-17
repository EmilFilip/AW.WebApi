using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AW.WepApi.DAL.RepositoryService
{
    public class BaseRepository<C> : IDisposable
        where C : DbContext, new()
    {
        private C _DataContext;

        public virtual C DataContext
        {
            get
            {
                if (_DataContext == null)
                {
                    _DataContext = new C();
                    this.AllowSerialization = true;
                    //Disable ProxyCreationDisabled to prevent the "In order to serialize the parameter, add the type to the known types collection for the operation using ServiceKnownTypeAttribute" error
                }
                return _DataContext;
            }
        }

        public virtual bool AllowSerialization
        {
            get
            {
                return _DataContext.Configuration.ProxyCreationEnabled;
            }
            set
            {
                _DataContext.Configuration.ProxyCreationEnabled = !value;
            }
        }

        public virtual T Get<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return DataContext.Set<T>().Where(predicate).SingleOrDefault();
        }

        public virtual IQueryable<T> GetList<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return GetList<T>().Where(predicate);
        }

        public virtual IQueryable<T> GetList<T, TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> orderBy) where T : class
        {
            return GetList<T>().Where(predicate).OrderBy(orderBy);
        }

        public virtual IQueryable<T> GetList<T, TKey>(Expression<Func<T, TKey>> orderBy) where T : class
        {
            return GetList<T>().OrderBy(orderBy);
        }

        public virtual IQueryable<T> GetList<T>() where T : class
        {
            return DataContext.Set<T>();
        }

        public virtual bool Insert<T>(T entity) where T : class
        {
            DataContext.Set<T>().Add(entity);
            return DataContext.SaveChanges() != 0 ? true : false;
        }

        public virtual bool Update<T>(T entity) where T : class
        {
            DataContext.Set<T>().Attach(entity);
            return DataContext.SaveChanges() != 0 ? true : false;
        }

        public virtual bool Delete<T>(T entity) where T : class
        {
            DataContext.Entry(entity).State = EntityState.Deleted;
            return DataContext.SaveChanges() != 0 ? true : false;
        }

        public virtual int ExecuteStoreCommand(string cmdText, params object[] parameters)
        {
            return DataContext.Database.ExecuteSqlCommand(cmdText, parameters);
        }

        public void Dispose()
        {
            if (DataContext != null) DataContext.Dispose();
        }
    }
}

