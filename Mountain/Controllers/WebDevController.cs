using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mountain.Controllers
{
    public class WebDevController : Controller
    {
        // GET: WebDev
        public ActionResult Index()
        {
            return View();
        }
    }
}