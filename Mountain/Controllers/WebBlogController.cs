using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mountain.Controllers
{
    public class WebBlogController : Controller
    {
        // GET: WebBlog
        public ActionResult Index()
        {
            return View();
        }
    }
}