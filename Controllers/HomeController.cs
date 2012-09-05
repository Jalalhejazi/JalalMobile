using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JalalMobile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "jQuerymobile MVC and REST DataServices";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This code is developed using Visual Studio 2012";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Jalal.Hejazi@gmail.com";

            return View();
        }
    }
}
