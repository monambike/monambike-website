namespace Monambike.WebAPI.Data
{
    public class Post
    {
        public int Id { get; set; }

        /// <summary>
        /// Website H1
        /// </summary>
        public string Title { get; set; }

        public PostSection PostSection { get; set; }

        public List<string> Tags { get; set; }

        public TimeSpan ReadingTime { get; set; }

        public DateTime CreationTime { get; set; }

        public Person Author { get; set; }

        public List<string> EditHistory { get; set; }

        public string URL { get; set; }

        public int Views { get; set; }


    }

    public class PostSection
    {
        /// <summary>
        /// Website H2
        /// </summary>
        public string Title { get; set; }

        public string Content { get; set; }
    }

    public class EditHistory
    {
        public Post Post { get; set; }

        public DateTime EditChangeTime { get; set; }
    }


    public class MajorCategory
    {
        public Category Category { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime DateTime { get; set; }
    }
}
