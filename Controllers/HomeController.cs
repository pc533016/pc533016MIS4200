using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pc533016MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Patrick Crago's Professional Bio.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please feel free to contact me.";

            return View();
        }
    }
}