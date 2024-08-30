using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traveling.Core.Repositories;


namespace Traveling.Core
{
    public interface IUnitOfWork : IDisposable // for interfaces to be disposed off each use
    {
        ITipRepository Tips { get; } // interface is used to get data

        int Complete();
    }
}