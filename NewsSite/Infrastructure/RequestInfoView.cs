using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NewsSite.Infrastructure
{
    public class RequestInfoView : IView
    {
        public void Render(ViewContext viewContext, TextWriter writer)
        {
            Write(writer, "<a href=\"/\">Return to gallery</a>");
            Write(writer, "<br/>");

            Write(writer, "<h3 class=\"text-center\">Request info</h3>");
            Write(writer, "<br/>");

            Write(writer, "<h4>Headers:</h4>");
            foreach (string key in viewContext.HttpContext.Request.Headers.Keys)
            {
                Write(writer, "<p>{0}: {1}</p>", key, viewContext.HttpContext.Request.Headers[key]);
            }
            Write(writer, "<br/>");

            Write(writer, "<h4>Cookies:</h4>");
            foreach (string key in viewContext.HttpContext.Request.Cookies.AllKeys)
            {
                Write(writer, "<p>{0}: {1}</p>", key, viewContext.HttpContext.Request.Cookies[key]);
            }
            Write(writer, "<br/>");

            Write(writer, "<h4>Post data:</h4>");
            foreach (string key in viewContext.HttpContext.Request.Form.AllKeys)
            {
                Write(writer, "<p>{0}: {1}</p>", key, viewContext.HttpContext.Request.Form[key]);
            }
            Write(writer, "<br/>");

            Write(writer, "<h4>Query parameters:</h4>");
            foreach (string key in viewContext.HttpContext.Request.Params.AllKeys)
            {
                Write(writer, "<p>{0}: {1}</p>", key, viewContext.HttpContext.Request.Params[key]);
            }
            Write(writer, "<br/>");
        }
        

        private void Write(TextWriter writer, string template, params object[] values)
        {
            writer.Write(string.Format(template, values));
        }
    }
}
