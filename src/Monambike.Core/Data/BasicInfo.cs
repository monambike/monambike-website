// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace Monambike.Core.Data
{
    /// <summary>
    /// Class that provides basic information about Vini.
    /// </summary>
    public static class BasicInfo
    {
        /// <summary>
        /// Vini's first name.
        /// </summary>
        public static string FirstName => "Vinícius Gabriel";

        /// <summary>
        /// Vini's second name.
        /// </summary>
        public static string SecondName => "Marques de Melo";

        /// <summary>
        /// Vini's username.
        /// </summary>
        public static string Username => "Monambike";

        /// <summary>
        /// Vini's social media username. (with an '@' symbol behind).
        /// </summary>
        public static string SocialMediaUsername => $"@{Username.ToLower()}";
    }
}
