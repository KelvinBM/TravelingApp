using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;

namespace Traveling.Core.Repositories
{
    // generic interface with parameter 'TEntity' that expects a class
    public interface IRepository<TEntity> where TEntity : class
    { // interfaces work as templates for the methods within the actual classes that are in the 'Persistence' namespace

        // methods within actual classes for interfaces must be of the same type as the interface

        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate); // this expression takes in a LAMDA expression and returns values based on the bool aspect
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);



    }
}