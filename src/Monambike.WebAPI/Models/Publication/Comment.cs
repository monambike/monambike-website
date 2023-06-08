using System;

namespace Monambike.WebAPI.Models.Posting
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public User User { get; set; }

        public DateTime DateTime { get; set; }
    }
}
