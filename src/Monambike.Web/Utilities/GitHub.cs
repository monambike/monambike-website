using Monambike.Web.Models;

namespace Monambike.Web.Utilities
{
    /// <summary>
    /// Represents a utility class for creating links to GitHub projects related to Monambike.
    /// </summary>
    public static class GitHub
    {
        private static readonly string defaultUrl = "https://github.com/monambike/";

        /// <summary>
        /// Creates a link to a GitHub project with the specified title and project name.
        /// </summary>
        /// <param name="title">The title of the github project.</param>
        /// <param name="repositoryName">The name of the GitHub repository which will be combined with
        /// the default URL.</param>
        /// <returns>A link to the GitHub project.</returns>
        private static Link CreateLinkForGitHubRepository(string title, string repositoryName)
            => new(title, defaultUrl + repositoryName, SocialMedia.GitHub, $"Click here to check my {title} repository on {SocialMedia.GitHub.Name}.");

        // Monambike GitHub repositories
        public static Link ProjectHanabi => CreateLinkForGitHubRepository("Project Hanabi", "project-hanabi-web");
    }
}
