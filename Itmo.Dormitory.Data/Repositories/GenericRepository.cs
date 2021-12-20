using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Itmo.Dormitory.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> Get()
        {
            return _dbSet;
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _dbSet.Where(predicate).AsQueryable();
        }
        public TEntity FindById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public TEntity Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
            return item;
        }
        public TEntity Update(TEntity item)
        {
            _dbSet.Update(item);
            _context.SaveChanges();
            return item;
        }

        public void Remove(TEntity item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
    }
}
