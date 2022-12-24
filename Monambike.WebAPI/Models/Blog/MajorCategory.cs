using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Blog
{
    public class MajorCategory
    {
        public Category Category { get; set; }

        public List<Post> Posts { get; set; }
    }
}
