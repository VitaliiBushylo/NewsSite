using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ClientFeatures;
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
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Add(new ViewEngine());
            
            ModelBinders.Binders.Add(typeof(Visitor), new VisitorModelBinder());

            ApplicationUpTimer.SetStartTime();
        }
    }
}
