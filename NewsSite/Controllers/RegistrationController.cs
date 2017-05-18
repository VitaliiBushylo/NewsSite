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
                if (visitor.Id == 0)
                {
                    int lastVisitorId = Registration.Visitors.Any() ? Registration.Visitors.Max(v => v.Id) : 0;
                    visitor.Id = ++lastVisitorId;
                }
                
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


        [ActionName("All")]
        public ActionResult AllVisitors()
        {
            return View("AllVisitors", Registration.Visitors);
        }

        [HttpGet]
        [ActionName("User")]
        public ActionResult Visitor(int? id)
        {
            var requestedVisitor = Registration.Visitors.FirstOrDefault(v => v.Id == id);

            if (requestedVisitor == null)
            {
                return new HttpNotFoundResult("Could not find a user.");
            }
            else
            {
                return View("Registration", requestedVisitor);
            }
        }

        [HttpPost]
        [ActionName("User")]
        public ActionResult Visitor(Visitor visitor)
        {
            var requestedVisitor = Registration.Visitors.FirstOrDefault(v => v.Id == visitor.Id);

            if (requestedVisitor == null)
            {
                return new HttpNotFoundResult("Could not find a user.");
            }
            else
            {
                int visitorIndex = Registration.Visitors.IndexOf(requestedVisitor);

                Registration.Visitors.Remove(requestedVisitor);
                Registration.Visitors.Insert(visitorIndex, visitor);

                return RedirectToAction("All");
            }
        }
    }
}