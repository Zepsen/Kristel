using System;
using System.Collections.Generic;

namespace Kristel.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        IEnumerable<TEntity> Find(Func<TEntity, Boolean> predicate);
        void Add(TEntity item);
        void Update(TEntity item);
        void Delete(int id);
    }
}
