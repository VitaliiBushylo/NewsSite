using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsSite.Infrastructure
{
    public class VisitorModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return new Visitor
            {
                Id = int.Parse(bindingContext.PropertyMetadata["Id"].ToString()),
                FirstName = bindingContext.PropertyMetadata["FirstName"].ToString(),
                LastName = bindingContext.PropertyMetadata["LastName"].ToString(),
                Email = bindingContext.PropertyMetadata["Email"].ToString(),
                Password = bindingContext.PropertyMetadata["Password"].ToString()
                //BirthDate = new DateTime(bindingContext.PropertyMetadata["BirthDate"])
            };
        }
    }
}