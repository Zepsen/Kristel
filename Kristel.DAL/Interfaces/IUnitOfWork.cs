using Kristel.DAL.Enities;
using System;

namespace Kristel.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> Products { get; }
        
    }
}
