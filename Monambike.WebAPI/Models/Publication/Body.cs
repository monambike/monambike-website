using Monambike.WebAPI.Models.Posting.Cards;

namespace Monambike.WebAPI.Models.Posting
{
    public class Body
    {
        private object Content = null;

        public Body() { }
        public Body(string paragraph) { Content = paragraph; }
        public Body(byte[] image) { Content = image; }
        public Body(Caution caution) { Content = caution; }
        public Body(Note note) { Content = note; }
        public Body(Tip tip) { Content = tip; }
        public Body(Warning warning) { Content = warning; }
    }
}