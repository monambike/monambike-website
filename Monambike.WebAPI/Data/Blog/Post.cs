namespace Monambike.WebAPI
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public List<string> Tags { get; set; }

        public TimeSpan ReadingTime { get; set; }

        public DateTime CreationTime { get; set; }

        public Person Author { get; set; }

        public List<string> EditHistory { get; set; }
    }

    public class EditHistory
    {
        public Post Post { get; set; }

        public DateTime EditChangeTime { get; set; }
    }
}
