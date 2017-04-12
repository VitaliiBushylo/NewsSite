using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsSite.Models;

namespace NewsSite.Controllers
{
    public class NewsListController : Controller
    {
        // GET: NewsList
        public ActionResult Index()
        {
            var news = new NewsModel();
            return View(news);
        }
    }
}