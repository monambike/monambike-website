namespace Monambike.WebAPI.Models.Blog
{
    public class PostSection
    {
        /// <summary>
        /// Website H2
        /// </summary>
        public string Title { get; set; }

        public string Content { get; set; }
    }

    public class Content
    {
        public string Paragraph { get; set; }

        public byte Image { get; set; }

        public byte Warning { get; set; }
    }
}
