using System;

namespace NewsSite.Models
{
    public class NewsEntry
    {
        public NewsEntry()
        {
            CreatedOn = DateTime.Now;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public Uri Origin { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
