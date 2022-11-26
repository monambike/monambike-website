namespace Monambike.WebAPI
{
    public abstract class Media
    {
        public int Id { get; set; }

        public byte Background { get; set; }

        public string Title { get; set; }

        public Status Status { get; set; }
    }

    public enum Status { Already, Current, WantTo }
}
