using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Traveling.Core.Repositories;

namespace Traveling.Persistence.Repositories
{
    // Generic class
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class// contains methods from its corresponding Interface within the Core.Repositoriese namespace
    {
        //protected readonly DbContext Context;
        private DbSet<TEntity> _entities;

        // attaching above variable to constructor
        public Repository(DbContext context)
        {
            //Context = context;
            _entities = context.Set<TEntity>();
        }

        public TEntity Get(int id)
        {
            //return Context.Set<TEntity>().Find(id);// using generic method 'Set()' to access specified tables
            return _entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public int GetCount(TEntity entity)
        {
            return _entities.Count();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _entities.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _entities.RemoveRange(entities);
        }
    }
}