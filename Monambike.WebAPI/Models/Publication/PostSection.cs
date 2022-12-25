using Monambike.WebAPI.Models.Posting.Cards;
using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Posting
{
    public class Topic
    {
        /// <summary>
        /// Website H2
        /// </summary>
        public string Title { get; set; }

        public List<Body> Body { get; set; } = new List<Body>
        {
            new Body("hello my friends"),
            new Body(0), // Image
            new Body(new Tip("be careful.."))
        };
    }
}
