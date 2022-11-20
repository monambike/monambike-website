namespace Monambike.WebAPI
{
    public abstract class Media
    {
        public int Id { get; set; }

        public byte Background { get; set; }

        public string Title { get; set; }

        public ConsumeStatus ConsumeStatus { get; set; }

        public string Status => GetConsumeStatus();

        public abstract string GetConsumeStatus();
    }

    public enum ConsumeStatus { Already, Current, WantTo }
}
