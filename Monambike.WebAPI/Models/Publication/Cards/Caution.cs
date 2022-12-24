namespace Monambike.WebAPI.Models.Posting.Cards
{
    public class Caution : Card
    {
        public override Color Color => new("");

        public override byte Icon => 0;

        public Caution(string content) : base(content) { }
    }
}
