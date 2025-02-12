using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traveling.Core;
using Traveling.Core.Domain;
using Traveling.Persistence;
using Traveling.ViewModels;

namespace Traveling.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IUnitOfWork _unitOfWork;// require an instance of the interface to access the values from tables // not working in methods
        private readonly TravelAppContext _context = new TravelAppContext();
       
        public HomeController()
        {
            //_unitOfWork = unitOfWork;
        }

        // Url: Home/Index
        public ActionResult Index()
        {
            var categories = _context.TravelCategories.Include(tc => tc.Destinations).ToList();// using eager loading to load related objects of TravelCategories(Destinations)
            var tips = _context.Tips.ToList();
            //var destinations = 

            var viewModel = new HomeViewModel
            {
                Categories = categories,
                Tips = tips
            };

            return View(viewModel);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Url: Home/AddDestination // View: AddDestionation
    }
}