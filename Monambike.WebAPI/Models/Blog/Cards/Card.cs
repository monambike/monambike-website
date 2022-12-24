using System.Reflection;

namespace Monambike.WebAPI.Models.Blog.Cards
{
    public abstract class Card
    {
        public int Id { get; set; }

        public string Title => GetType().Name;

        public string Body { get; set; }

        public abstract Color Color { get; }

        public abstract byte Icon { get; }
    }
}
