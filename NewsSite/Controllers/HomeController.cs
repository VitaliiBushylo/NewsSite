using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsSite.Models;

namespace NewsSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return Redirect("NewsList/Index");
        //}

        public ActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ContactUs()
        {
            var feedback = new FeedbackEntry() { UserName = "Your name", Email = "your.email@i.ua"};
            return View(feedback);
        }

        [HttpPost]
        public ActionResult ContactUs(FeedbackEntry feedbackEntry)
        {
            return View();
        }
    }
}