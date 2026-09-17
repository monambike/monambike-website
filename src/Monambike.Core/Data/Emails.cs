using Monambike.Core.Entities;

namespace Monambike.Core.Data
{
    /// <summary>
    /// Emails for Monambike's accounts.
    /// </summary>
    public static class Emails
    {
        /// <summary>
        /// The contact email for monambike domain.
        /// </summary>
        public static Email Contact => new("contact@monambike.com");
    }
}
