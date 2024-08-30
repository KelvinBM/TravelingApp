using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traveling.Core;
using Traveling.Core.Domain;
using Traveling.Persistence;

namespace Traveling.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IUnitOfWork _unitOfWork;// require an instance of the interface to access the values from tables
        private readonly TravelAppContext _context = new TravelAppContext();
        public HomeController()
        {
            //_unitOfWork = unitOfWork;
            
        }

        public ActionResult Index()
        {
            var tips = _context.Tips;
            return View(tips);
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
    }
}