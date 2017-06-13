using System;
using System.ComponentModel.DataAnnotations;

namespace NewsSite.Models
{
    public class NewsEntry
    {
        public NewsEntry()
        {
            CreatedOn = DateTime.Now;
        }

        [Display(Name = "Article Title")]
        public string Title { get; set; }

        [Display(Name = "Article Content")]
        public string Content { get; set; }

        public Uri Origin { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
