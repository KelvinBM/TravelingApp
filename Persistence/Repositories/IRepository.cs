using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Traveling.Persistence.Repositories
{
    // G
    public class IRepository<TEntity> // contains methods from its corresponding Interface within the Core.Repositoriese namespace
    {
        protected readonly DbContext Context;

        // attaching above variable to constructor
        public IRepository()
        {

        }
        
    }
}