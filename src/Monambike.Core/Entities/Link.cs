namespace Monambike.Core.Entities
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Link"/> class with the specified URL.
    /// </summary>
    /// <param name="baseUrl">The base URL of the link. Example: for "https://example.com" should be "example.com"</param>
    public class Link(string baseUrl)
    {
        /// <summary>
        /// Gets the base URL of the link.
        /// </summary>
        public string BaseUrl => baseUrl;

        /// <summary>
        /// Gets the URL of the link with HTTPS protocol.
        /// </summary>
        public Uri Url => new($"https://{BaseUrl}");

        /// <summary>
        /// Returns the URL of the link with https protocol as string.
        /// </summary>
        /// <returns>The URL as <see cref="string"/>.</returns>
        public override string ToString() => Url.ToString();
    }
}
