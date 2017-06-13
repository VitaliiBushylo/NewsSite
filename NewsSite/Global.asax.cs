using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using NewsSite.Infrastructure;
using NewsSite.Models;

namespace NewsSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Add(new ViewEngine());
            
            ModelBinders.Binders.Add(typeof(Visitor), new VisitorModelBinder());

            ApplicationUpTimer.SetStartTime();
        }
    }
}
