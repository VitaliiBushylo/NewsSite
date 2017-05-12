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
                Visitors = new List<Visitor>();
        }
        public static IList<Visitor> Visitors { get; set; }
    }
}
