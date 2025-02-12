using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traveling.Core.Domain;
using Traveling.Persistence;

namespace Traveling.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly TravelAppContext _context = new TravelAppContext();
        // GET: Destinations
        public ActionResult Index(int destinationId)
        {
            List<Destination> destinations = _context.Destinations.ToList();
            // need to relearn almost everything since I kinda forgot :)
            return View();
        }

        public ViewResult DestinationInfo(int destinationId)
        {
            return View(destinationId);
        }
    }
}