using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// using Mountain.Models;

namespace Mountain.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Comment to test GitHub
            //TEST

            ViewBag.currentTime = DateTime.Now;
            return View();
        }

        public ActionResult About()
        { 
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}