using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsSite.Models;

namespace NewsSite.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Registration", new Visitor { BirthDate = DateTime.Now });
        }

        [HttpPost]
        public ActionResult Index(Visitor visitor)
        {
            if (visitor != null)
            {
                Registration.Visitors.Add(visitor);

                return View("ThanksForJoining", visitor);
            }
            else
            {
                return View("Registration", new Visitor {BirthDate = DateTime.Now});
            }
        }

        [ChildActionOnly]
        public ActionResult Uptime()
        {
            return PartialView("_ApplicationUptime", ApplicationUpTimer.CurrentUptime);
        }

        public ActionResult AllVisitors()
        {
            return View(Registration.Visitors);
        }
    }
}