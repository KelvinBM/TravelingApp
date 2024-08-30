using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traveling.Core;
using Traveling.Core.Domain;


namespace Traveling.Controllers
{
    public class TipController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TipController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Tip
        public ActionResult Index()
        {
            return View();
        }
    }
}