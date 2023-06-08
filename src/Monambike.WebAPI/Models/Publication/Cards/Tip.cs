namespace Monambike.WebAPI.Models.Posting.Cards
{
    public class Tip : Card
    {
        public override Color Color => new("");

        public override byte[] Icon => new byte[0];

        public Tip(string content) : base(content) { }
    }
}
