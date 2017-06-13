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
        NewsModel newsModel = new NewsModel();

        public ActionResult Index()
        {            
            return View(newsModel);
        }

        [HttpGet]
        public ActionResult CreateNews()
        {
            return View(new List<NewsEntry> { new NewsEntry(), new NewsEntry(), new NewsEntry() });
        }

        [HttpPost]
        public ActionResult CreateNews(FormCollection newsToCreate)
        {
            
            foreach (var news in newsToCreate)
            {

                var val = newsToCreate[news.ToString()];
               // if (!string.IsNullOrEmpty(news.Title) && !string.IsNullOrEmpty(news.Content))
               // {
               //     news.CreatedOn = DateTime.Now;
               //     newsModel.News.Add(news);
               // }
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