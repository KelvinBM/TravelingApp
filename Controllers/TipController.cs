using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traveling.Models;


namespace Traveling.Controllers
{
    public class TipController : Controller
    { 
        public TipController()
        {

        }

        // GET: Tip
        public ActionResult Index()
        {
            return View();
        }
    }
}