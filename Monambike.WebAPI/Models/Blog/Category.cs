using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Blog
{
    public class Category
    {
        List<Category> Categories { get; set; }

        List<Post> Posts { get; set; }
    }
}
