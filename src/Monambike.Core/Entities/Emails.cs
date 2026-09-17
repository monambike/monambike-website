namespace Monambike.Core.Entities
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Email"/> class with the specified email address.
    /// </summary>
    /// <param name="emailAddress">The email address.</param>
    public class Email(string emailAddress)
    {
        /// <summary>
        /// Gets the email address.
        /// </summary>
        public string Address => new($"{emailAddress}");

        /// <summary>
        /// Gets the URL of the email address with the prefix "mailto:".
        /// </summary>
        public string Link => new($"mailto:{Address}");

        /// <summary>
        /// Returns the email address as string.
        /// </summary>
        /// <returns>The email address as <see cref="string"/>.</returns>
        public override string ToString() => Address.ToString();
    }
}
