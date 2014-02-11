using System;
using System.Linq;
using System.Linq.Expressions;

namespace Dragon.Repositories.Interfaces
{
    public interface IRepository<T> : IDisposable
    {
        IQueryable<T> All { get; }
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        T Find(long id);
        void InsertOrUpdate(T entity);
        void Delete(long id);
    }
}
