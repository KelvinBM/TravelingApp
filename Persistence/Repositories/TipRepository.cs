using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traveling.Core.Repositories;
using Traveling.Persistence;
using Traveling.Core.Domain;

namespace Traveling.Persistence.Repositories
{
    public class TipRepository : Repository<Tip>, ITipRepository// derives from this class and implements this repository
    {
        public TipRepository(TravelAppContext context) : base(context)
        {

        }
    }
}