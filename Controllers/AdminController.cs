using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traveling.Core.Domain;
using Traveling.Persistence;
using Traveling.ViewModels;

namespace Traveling.Controllers
{
    public class AdminController : Controller
    {
        private readonly TravelAppContext _context = new TravelAppContext();

        public AdminController()
        {
            //_context = context;
        }


        // GET: Admin  ||  Admin/Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDestination()
        {
            var categories = _context.TravelCategories.ToList();
            var viewModel = new NewDestinationViewModel
            {
                Categories = categories
            };
            return View(viewModel);
        }

        [HttpPost]// to make sure this action can only be called using 'HttpPost' -> not 'HttpGet'
        public ActionResult CreateDestination(Destination destination) // to actually create new destination
        {
            // implements model binding:
            //      - requested parameter data is binded to request data 
            //      - can pass either viewModel or actually requested datatype
            //      - allows creating data request
            //      - entity framework uses properties passed through form to initialize this parameter 'viewModel'
            _context.Destinations.Add(destination);
            _context.SaveChanges();

            return RedirectToAction("AddDestination", "Admin");
        }
    }
}