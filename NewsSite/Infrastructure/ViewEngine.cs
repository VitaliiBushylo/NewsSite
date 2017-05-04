using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NewsSite.Infrastructure
{
    public class ViewEngine : IViewEngine
    {
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            return new ViewEngineResult(new [] { "There is no such view " + partialViewName });
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (viewName == "RequestInfo")
            {
                return new ViewEngineResult(new RequestInfoView(), this);
            }
            else
            {
                return new ViewEngineResult(new[] { "There is no such view " + viewName });
            }
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
           
        }
    }
}
