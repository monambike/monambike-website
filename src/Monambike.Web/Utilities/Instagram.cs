using Monambike.Web.Models;

namespace Monambike.Web.Utilities
{
    /// <summary>
    /// Represents a utility class for creating links to Monambike's Instagram accounts.
    /// </summary>
    public static class Instagram
    {
        private static readonly string defaultUrl = "https://www.instagram.com/";

        /// <summary>
        /// Creates a link to an Instagram account with the specified title and username.
        /// </summary>
        /// <param name="accountName">The title of the link.</param>
        /// <param name="username">The username of the Instagram account, which will be
        /// combined with the default URL.</param>
        /// <returns>A link to the Instagram account.</returns>
        private static Link CreateLinkForInstagramAccount(string accountName, string username)
            => new(accountName, defaultUrl + username, SocialMedia.Instagram, $"Click here to check my instagram profile for {accountName}.");

        // Monambike Instagram accounts
        public static Link Monambike => CreateLinkForInstagramAccount("Monambike", "monambike");
        public static Link MonambikePortfolio => CreateLinkForInstagramAccount("Monambike Portfolio", "monambike_portfolio");
        public static Link MonambikePhotos => CreateLinkForInstagramAccount("Monambike Photos", "monambike_photos");
    }
}
