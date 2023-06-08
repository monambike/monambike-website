namespace Monambike.WebAPI.Models.Posting.Cards
{
    public class Warning : Card
    {
        public override Color Color => new("");

        public override byte[] Icon => new byte[0];

        public Warning(string content) : base(content) { }
    }
}
