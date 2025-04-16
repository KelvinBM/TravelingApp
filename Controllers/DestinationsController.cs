using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traveling.Core.Domain;
using Traveling.Persistence;
using Traveling.Persistence.Repositories;

namespace Traveling.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly TravelAppContext _context = new TravelAppContext();
        // GET: Destinations
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Index()// cannot have parameter
        //{
        //    return View();
        //}

        public ViewResult DestinationInfo(int destinationId)
        {
            var destination = _context.Destinations.SingleOrDefault(d => d.Id == destinationId);
            return View(destination);
        }

    }
}