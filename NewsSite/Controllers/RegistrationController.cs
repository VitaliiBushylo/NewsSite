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
                return View("Registration", new Visitor { BirthDate = DateTime.Now });
            }
        }

        [ChildActionOnly]
        public ActionResult Uptime()
        {
            return PartialView("_ApplicationUptime", ApplicationUpTimer.CurrentUptime);
        }


        [ActionName("All")]
        public ActionResult AllVisitors(string orderBy)
        {
            return View("AllVisitors", Registration.Visitors);
        }


        public ActionResult Ordered(string orderBy)
        {
            switch (orderBy)
            {
                case "Id": { return PartialView("VisitorList", Registration.Visitors.OrderBy(v => v.Id).ToList()); }
                case "FirstName": { return PartialView("VisitorList", Registration.Visitors.OrderBy(v => v.FirstName).ToList()); }
                case "LastName": { return PartialView("VisitorList", Registration.Visitors.OrderBy(v => v.LastName).ToList()); }
                case "BirthDate": { return PartialView("VisitorList", Registration.Visitors.OrderBy(v => v.BirthDate).ToList()); }
                case "Email": { return PartialView("VisitorList", Registration.Visitors.OrderBy(v => v.Email).ToList()); }
                default: { return PartialView("VisitorList", Registration.Visitors); }
            }

            //switch (orderBy)
            //{
            //    case "Id": { return Json(Registration.Visitors.OrderBy(v => v.Id).Select(s => new { Id = s.Id, FirstName = s.FirstName, LastName = s.LastName, BirthDate = s.BirthDate.ToString("dd-MM-yyyy"), Email = s.Email }), JsonRequestBehavior.AllowGet); }
            //    case "FirstName": { return Json(Registration.Visitors.OrderBy(v => v.FirstName).Select(s => new { Id = s.Id, FirstName = s.FirstName, LastName = s.LastName, BirthDate = s.BirthDate.ToString("dd-MM-yyyy"), Email = s.Email }), JsonRequestBehavior.AllowGet); }
            //    case "LastName": { return Json(Registration.Visitors.OrderBy(v => v.LastName).Select(s => new { Id = s.Id, FirstName = s.FirstName, LastName = s.LastName, BirthDate = s.BirthDate.ToString("dd-MM-yyyy"), Email = s.Email }), JsonRequestBehavior.AllowGet); }
            //    case "BirthDate": { return Json(Registration.Visitors.OrderBy(v => v.BirthDate).Select(s => new { Id = s.Id, FirstName = s.FirstName, LastName = s.LastName, BirthDate = s.BirthDate.ToString("dd-MM-yyyy"), Email = s.Email }), JsonRequestBehavior.AllowGet); }
            //    case "Email": { return Json(Registration.Visitors.OrderBy(v => v.Email).Select(s => new { Id = s.Id, FirstName = s.FirstName, LastName = s.LastName, BirthDate = s.BirthDate.ToString("dd-MM-yyyy"), Email = s.Email }), JsonRequestBehavior.AllowGet); }
            //    default: { return PartialView("VisitorList", Registration.Visitors); }
            //}

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
                return PartialView("EditVisitorForm", requestedVisitor);
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

                if (Request.IsAjaxRequest())
                {
                    return Json(visitor);
                }
                else
                {
                    return RedirectToAction("All");
                }
            }
        }


    }
}