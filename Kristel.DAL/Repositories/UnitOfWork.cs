using Kristel.DAL.Interfaces;
using System;
using Kristel.DAL.Enities;
using System.Data;
using System.Data.SqlClient;

namespace Kristel.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private string _connectionString = null;
        private IDbConnection _db;

        public UnitOfWork(string connectionString)
        {
            _connectionString = connectionString;
            _db = new SqlConnection(_connectionString);
        }

         
        private Repository<Product> _products;

        public IRepository<Product> Products => (_products ?? (_products = new Repository<Product>(_db)));
               

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
