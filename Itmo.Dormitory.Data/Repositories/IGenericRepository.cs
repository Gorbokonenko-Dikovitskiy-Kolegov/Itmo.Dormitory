using System;
using System.Linq;

namespace Itmo.Dormitory.Data.Repositories
{
    public interface IGenericRepository<TEntity>
       where TEntity : class
    {
        TEntity Create(TEntity item);
        TEntity FindById(Guid id);
        IQueryable<TEntity> Get();
        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        TEntity Update(TEntity item);
    }
}
