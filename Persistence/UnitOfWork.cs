using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Traveling.Core;
using Traveling.Core.Repositories;
//using Traveling.Core.Domain;

namespace Traveling.Persistence
{
    public class UnitOfWork : IUnitOfWork // this class implements this interface
    {
        private readonly TravelAppContext _travelContext;

        public UnitOfWork(TravelAppContext travelContext)
        {
            _travelContext = travelContext;
        }

        // implementing interfaces // any interface within the Unit of Work must be implemented here //
        public ITipRepository Tips { get; private set; }

        public int Complete()
        {
            return _travelContext.SaveChanges();
        }

        public void Dispose()
        {
            _travelContext.Dispose();
        }
    }
}