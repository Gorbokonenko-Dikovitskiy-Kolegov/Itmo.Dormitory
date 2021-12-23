using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.Dormitory.Data.Repositories
{
    public interface IGenericRepository<TEntity>
       where TEntity : class
    {
        TEntity Add(TEntity item);
        TEntity FindById(Guid id);
        IEnumerable<TEntity> GetAll();
        //IQueryable<TEntity> Get();
        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(Guid id);
        TEntity Update(TEntity item);
    }
}
