using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitOperatoins.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult NewIndex()
        {
            return View();
        }

        public ActionResult AboutNew()
        {
            Console.Write("new changes");
            ViewBag.Message = "Your application description page.";
            Console.Write("new changes");
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Console.Write("new changes");
            return View();
        }

        public ActionResult ReContact()
        {
            ViewBag.Message = "Your contact page.";
            Console.Write("new changes");
            return View();
        }

        public ActionResult NewC12233()
        {
            ViewBag.Message = "Your contact page.";
            Console.Write("new changes");
            return View();
        }

        public ActionResult C1()
        {
            ViewBag.Message = "Your contact page.";
            Console.Write("new changes");
            return View();
        }

        public ActionResult C2()
        {
            ViewBag.Message = "Your contact page.";
            Console.Write("new changes");
            return View();
}

    }
}