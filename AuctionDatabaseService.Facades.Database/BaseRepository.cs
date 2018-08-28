using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AuctionDatabaseService.Facades.Database.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        public readonly DatabaseContext _context;

        public readonly DbSet<T> _dbSet;

        public BaseRepository()
        {
            _context = DatabaseContextUtilities.Context;
            _dbSet = _context.Set<T>();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            var updatedEntity = _context.Entry(entity).GetDatabaseValues().ToObject();
            return updatedEntity as T;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
            _context.SaveChanges();
        }


        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T Update(T entity)
        {
            _dbSet.AddOrUpdate(entity);
            _context.SaveChanges();
            var updatedEntity = _context.Entry(entity).GetDatabaseValues().ToObject();
            return updatedEntity as T;
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
            _context.SaveChanges();
        }
    }
}
