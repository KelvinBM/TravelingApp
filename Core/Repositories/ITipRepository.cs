using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traveling.Core.Domain;

namespace Traveling.Core.Repositories
{
    // this interface is then implemented into the class correspondent to this repository
    public interface ITipRepository : IRepository<Tip> // this interface derives from the IRepository interface and has the Entity 'Tip' as value to expected parameter
    {
    }
}