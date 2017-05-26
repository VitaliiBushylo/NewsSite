using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSite.Models
{
    public static class Registration
    {
        static Registration()
        {
            if (Visitors == null)
                Visitors = new List<Visitor>
                {
                    new Visitor { Id = 1, BirthDate = new DateTime(1983, 10, 12), FirstName = "Vert", LastName = "Bu", Email = "vertbu@i.ua", Password = "passbu"},
                    new Visitor { Id = 2, BirthDate = new DateTime(2000, 3, 8), FirstName = "Some", LastName = "Other", Email = "someother@i.ua", Password = "passother"},
                    new Visitor { Id = 3, BirthDate = new DateTime(1999, 1, 1), FirstName = "Santa", LastName = "Claus", Email = "santa@i.ua", Password = "passsanta"}
                };
        }
        public static List<Visitor> Visitors { get; set; }
    }
}
