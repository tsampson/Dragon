using System.Data.Entity;

namespace Dragon.DomainClasses.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork where T : DbContext, new()
    {
        private readonly T _context;

        public UnitOfWork()
        {
            _context = new T();
        }

        public UnitOfWork(T context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public DbContext Context
        { get { return _context; } }
    }
}
