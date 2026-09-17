// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

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
