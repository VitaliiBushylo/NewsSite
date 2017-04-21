using System;
using System.Collections.Generic;
using System.IO;
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

        /*
        TODO: read about
        Session
        TempData
        */

        public ActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ContactUs()
        {
            var feedback = new FeedbackEntry() { UserName = "Your name", Email = "your.email@i.ua" };
            return View(feedback);
        }

        [HttpPost]
        public ActionResult ContactUs(FeedbackEntry feedbackEntry)
        {
            return View();
        }

        public ActionResult ImageGallery(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                return View(new List<string>());

            try
            {
                return new FileStreamResult(new FileStream(string.Format(@"D:\GL\desktop images\temp\{0}.jpg", filename), FileMode.Open), "image/jpeg");
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult(ex.Message);
            }
        }
    }
}