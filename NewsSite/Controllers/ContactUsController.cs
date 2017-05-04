using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsSite.Models;

namespace NewsSite.Controllers
{
    public class ContactUsController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            var feedback = new FeedbackEntry() { UserName = "Your name", Email = "your.email@i.ua" };
            return View(feedback);
        }

        [HttpPost]
        public ActionResult Index(FeedbackEntry feedbackEntry)
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Uptime()
        {
            return PartialView("_ApplicationUptime", ApplicationUpTimer.CurrentUptime);
        }
    }
}