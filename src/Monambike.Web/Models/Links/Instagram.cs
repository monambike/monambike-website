namespace Monambike.Web.Models.Links
{
    /// <summary>
    /// Represents a utility class for creating links to Monambike's Instagram accounts.
    /// </summary>
    public class Instagram
    {
        private static readonly string defaultUrl = "https://www.instagram.com/";

        /// <summary>
        /// Creates a link to an Instagram account with the specified title and username.
        /// </summary>
        /// <param name="title">The title of the link.</param>
        /// <param name="username">The username of the Instagram account, which will be
        /// combined with the default URL.</param>
        /// <returns>A link to the Instagram account.</returns>
        private static Link CreateLink(string title, string username)
            => new(title, defaultUrl + username, SocialMedia.Instagram);

        // Monambike Instagram accounts
        public static Link Monambike => CreateLink("Monambike", "monambike");
        public static Link MonambikePortfolio => CreateLink("Monambike Portfolio", "monambike_portfolio");
        public static Link MonambikePhotos => CreateLink("Monambike Photos", "monambike_photos");
    }
}
