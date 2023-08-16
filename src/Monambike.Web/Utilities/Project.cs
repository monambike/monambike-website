using Monambike.Web.Models;

namespace Monambike.Web.Utilities
{
    /// <summary>
    /// Represents a utility class for creating links to Monambike's projects.
    /// </summary>
    public static class Project
    {
        new Project(
            "Project Hanabi",
            "A personal project of a web application made primarily for testing and strengthen my habilities with programming and languages..",
            "/images/project1.jpg",
            new List<Link>
            {
                GitHub.ProjectHanabi,
            },
            new List<ProgrammingLanguage> { ProgrammingLanguage.HTML, ProgrammingLanguage.JavaScript }
        );
    }
}
