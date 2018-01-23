using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace Mountain.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        
        public ActionResult Index()
        {
            return View();
        }
    }
}