using System;

namespace Monambike.WebAPI.Models.Blog
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime DateTime { get; set; }
    }
}
