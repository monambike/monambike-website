using System;
using System.Collections.ObjectModel;

namespace Common.WebAPI
{
    public class Blog
    {
        public Collection<Post> Posts { get; set; }
    }

    public class Post
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public Collection<Change> Changes { get; set; }
    }

    public class Change
    {
        public User User { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
