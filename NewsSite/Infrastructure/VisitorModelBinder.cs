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
            var idResult = bindingContext.ValueProvider.GetValue("Id");
            int id = 0;
            int.TryParse(bindingContext.ValueProvider.GetValue("Id")?.AttemptedValue, out id);
            
            return new Visitor
            {
                Id = id,
                FirstName = bindingContext.ValueProvider.GetValue("FirstName")?.AttemptedValue,
                LastName = bindingContext.ValueProvider.GetValue("LastName")?.AttemptedValue,
                Email = bindingContext.ValueProvider.GetValue("Email")?.AttemptedValue,
                Password = bindingContext.ValueProvider.GetValue("Password")?.AttemptedValue,
                BirthDate = GetBirthDate(bindingContext)
            };
        }

        private DateTime GetBirthDate(ModelBindingContext context)
        {
            ValueProviderResult dayResult = context.ValueProvider.GetValue("BirthDate.Day");
            ValueProviderResult monthResult = context.ValueProvider.GetValue("BirthDate.Month");
            ValueProviderResult yearResult = context.ValueProvider.GetValue("BirthDate.Year");

            int day, month, year;
            int.TryParse(dayResult.AttemptedValue, out day);
            int.TryParse(monthResult.AttemptedValue, out month);
            int.TryParse(yearResult.AttemptedValue, out year);

            return new DateTime(year, month, day);
        }
    }
}