using System;
using System.Data.Entity;

namespace Dragon.DomainClasses.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        DbContext Context { get; }
    }
}
