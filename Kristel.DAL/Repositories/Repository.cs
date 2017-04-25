using Dapper;
using Kristel.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace Kristel.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private IDbConnection _db;

        public Repository(IDbConnection db)
        {
            _db = db;
            
        }

        public void Add(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return  _db.Query<TEntity>($"SELECT * FROM {typeof(TEntity).Name}");            
        }

        public void Update(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
