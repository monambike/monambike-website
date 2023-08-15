namespace Monambike.Web.Models
{
    /// <summary>
    /// Represents a link with associated metadata such as title, URL, and
    /// social media information.
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Gets the title of the link.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the URL of the link.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the hover information of the link.
        /// </summary>
        public string HoverInformation { get; }

        /// <summary>
        /// Gets the associated social media information for the link.
        /// </summary>
        public SocialMedia SocialMedia { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Link"/> class with the specified title, URL, and social media information.
        /// </summary>
        /// <param name="title">The title of the link.</param>
        /// <param name="url">The URL of the link.</param>
        /// <param name="socialMedia">The associated social media information.</param>
        public Link(string title, string url, SocialMedia socialMedia, string hoverInformation)
        {
            Title = title;
            Url = url;
            SocialMedia = socialMedia;
            HoverInformation = hoverInformation;
        }
    }
}
