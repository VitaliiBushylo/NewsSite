using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsSite.Models;

namespace NewsSite.Controllers
{
    public class RequestInfoController : Controller
    {
        public ActionResult Index()
        {
            return View("RequestInfo");
        }

        [ChildActionOnly]
        public ActionResult Uptime()
        {
            return PartialView("_ApplicationUptime", ApplicationUpTimer.CurrentUptime);
        }
    }
}