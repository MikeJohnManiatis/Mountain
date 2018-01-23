using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mountain.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            ViewBag.selfPic = Url.Content("../Images/selfPic.jpg");
            return View();
        }
    }
}