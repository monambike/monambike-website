namespace Monambike.Web.Models.Links
{
    /// <summary>
    /// Represents a utility class for creating links to GitHub projects related to Monambike.
    /// </summary>
    public static class GitHubProject
    {
        private static readonly string defaultUrl = "https://github.com/monambike/";

        /// <summary>
        /// Creates a link to a GitHub project with the specified title and project name.
        /// </summary>
        /// <param name="title">The title of the link.</param>
        /// <param name="projectName">The name of the GitHub project (repository), which will
        /// be combined with the default URL.</param>
        /// <returns>A link to the GitHub project.</returns>
        private static Link CreateLink(string title, string projectName)
            => new(title, defaultUrl + projectName, SocialMedia.GitHub);

        // Monambike GitHub projects
        public static Link ProjectHanabi => CreateLink("Project Hanabi", "project-hanabi-web");
    }
}
