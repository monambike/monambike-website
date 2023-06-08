namespace Monambike.WebAPI.Models.Posting.Cards
{
    public class Note : Card
    {
        public override Color Color => new("");

        public override byte[] Icon => new byte[0];

        public Note(string content) : base(content) { }
    }
}
