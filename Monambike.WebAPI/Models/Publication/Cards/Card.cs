using System.Reflection;

namespace Monambike.WebAPI.Models.Posting.Cards
{
    public abstract class Card
    {
        public Card(string content) => Content = content;

        public int Id { get; set; }

        public string Title => GetType().Name;

        public string Content { get; set; }

        public abstract Color Color { get; }

        public abstract byte[] Icon { get; }
    }
}
