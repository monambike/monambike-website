using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Posting
{
    public class Views
    {
        public int Id { get; set; }

        public int TotalViews => UserViews.Count + AnonymViews;

        public int AnonymViews { get; set; }

        public List<User> UserViews { get; set; }
    }
}
