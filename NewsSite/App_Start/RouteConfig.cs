using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NewsSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
               name: "HomeRoute",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "ImageGallery", action = "Index", id = UrlParameter.Optional });

            //routes.MapRoute(
            //   name: "HomeRoute",
            //   url: "{controller}/{action}/{filename}",
            //   defaults: new { controller = "ImageGallery", action = "Index", filename = UrlParameter.Optional });

            //routes.MapRoute(
            //   name: "RegistrationRoute",
            //   url: "{controller}/{action}/{visitorId}",
            //   defaults: new { controller = "Registration", action = "User", visitorId = 0 });


        }
    }
}
