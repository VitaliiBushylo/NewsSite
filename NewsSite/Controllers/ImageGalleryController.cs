using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsSite.Models;

namespace NewsSite.Controllers
{
    public class ImageGalleryController : Controller
    {
        public ActionResult Index(string filename)
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

        [ChildActionOnly]
        public ActionResult Uptime()
        {
            return new EmptyResult();
        }
    }
}