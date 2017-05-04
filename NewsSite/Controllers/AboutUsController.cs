using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsSite.Models;

namespace NewsSite.Controllers
{
    public class AboutUsController : Controller
    {
        public ActionResult Index()
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