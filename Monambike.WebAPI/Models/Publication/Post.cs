using Monambike.WebAPI.Models.Publication.Visibility;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Monambike.WebAPI.Models.Posting
{
    public partial class Post
    {
        public int Id { get; set; }

        /// <summary>
        /// Website H1
        /// </summary>
        public string Title { get; set; }

        public List<Topic> Topics { get; set; }

        public Base Visibility { get; set; }


        [GeneratedRegex("[^a-zA-Z0-9\\ ]+")]
        private static partial Regex LettersNumbersAndWhitespacesRegex();
        /// <summary>
        /// Example: "Blog Post Name!" becomes "blog-post-name".
        /// </summary>
        public string URL
        {
            get
            {
                // Removing everything that's not a letter, number or whitespace
                // on the title
                string titleLettersNumbersAndWhitespaces = LettersNumbersAndWhitespacesRegex().Replace(Title, string.Empty);
                // Replacing whitespaces by "-" and making it lower to make post url
                var url = titleLettersNumbersAndWhitespaces.ToLower().Replace(' ', '-');
                return url;
            }
        }

        public List<string> Tags { get; set; }


        /// <summary>
        /// https://stackoverflow.com/questions/4216752/anyone-having-any-leads-on-a-reading-time-algorithm
        /// word_count / 150
        /// </summary>
        public TimeSpan ReadingTime { get; set; }

        public List<Comment> Comments { get; set; }

        public Views Views { get; set; }



        public User Author { get; set; }

        public DateTime CreationTime { get; set; }

        public List<string> EditHistory { get; set; }

        //public Visibility Visibility { get; set; }
    }
}
