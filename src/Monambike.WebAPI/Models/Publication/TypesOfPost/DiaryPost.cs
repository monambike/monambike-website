using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Posting.TypesOfPost
{
    public class DiaryTest : Post
    {
        /// <summary>
        /// It may be different because I note at somewhere and later
        /// decided to post.
        /// </summary>
        public DateTime WroteDate { get; set; }

        /// <summary>
        /// 0 to 10, how I was feeling.
        /// </summary>
        public decimal Feeling { get; set; }


        public List<Tag> Tags { get; set; }
    }
}
