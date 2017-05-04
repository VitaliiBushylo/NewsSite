using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSite.Models
{
    public static class ApplicationUpTimer
    {
        private static DateTime _startTime;

        public static TimeSpan CurrentUptime { get { return DateTime.Now - _startTime; } }

        public static void SetStartTime()
        {
            _startTime = DateTime.Now;
        }
    }
}
