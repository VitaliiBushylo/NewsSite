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
        public ActionResult Index()
        {            
            return View(NewsModel.News);
        }

        [HttpGet]
        public ActionResult CreateNews()
        {
            return View(new List<NewsEntry> { new NewsEntry(), new NewsEntry(), new NewsEntry() });
        }

        [HttpPost]
        public ActionResult CreateNews(IList<NewsEntry> newsToCreate)
        {
            
            foreach (var news in newsToCreate)
            {
                if (!string.IsNullOrEmpty(news.Title) && !string.IsNullOrEmpty(news.Content))
                {
                    news.CreatedOn = DateTime.Now;
                    NewsModel.News.Add(news);
                }
            }

            return RedirectToAction("Index");
        }

        [ChildActionOnly]
        public ActionResult Uptime()
        {
            return PartialView("_ApplicationUptime", ApplicationUpTimer.CurrentUptime);
        }
    }
}