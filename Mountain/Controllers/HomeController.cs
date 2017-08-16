using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Mountain.Models;

namespace Mountain.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.currentTime = DateTime.Now.ToString("MM/dd/yyyy");

            //List<string> bookList = new List<string>();
            //bookList.Add("Pragmatic Programmer");
            //bookList.Add("Testing 2");


            //added this in the view incomplete.

            ViewBag.book1 = "Pragmatic Programmer";
            ViewBag.book2 = "Iwo Jima";


           
            
            
                     
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