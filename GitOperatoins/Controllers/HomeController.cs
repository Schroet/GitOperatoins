using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitOperatoins.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Contact112255()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult C1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult C2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}