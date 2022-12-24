using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Blog
{
    public class Views
    {
        public int Id { get; set; }

        public int TotalViews => UsersVisualizations.Count + AnonymViews;

        public int AnonymViews { get; set; };

        public List<Person> UsersVisualizations { get; set; }
    }
}
