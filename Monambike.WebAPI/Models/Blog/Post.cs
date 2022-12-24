using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Blog
{
    public class Post
    {
        public int Id { get; set; }

        /// <summary>
        /// Website H1
        /// </summary>
        public string Title { get; set; }

        public List<PostSection> PostSections { get; set; }


        public string URL { get; set; }

        public List<string> Tags { get; set; }

        public TimeSpan ReadingTime { get; set; }

        public Views Views { get; set; }



        public Person Author { get; set; }

        public DateTime CreationTime { get; set; }

        public List<string> EditHistory { get; set; }
    }
}
