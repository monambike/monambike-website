using Monambike.Web.Models.Links;

namespace Monambike.Web.Models
{
    /// <summary>
    /// Represents information about a project, including its name, description, image path, associated links, and programming languages.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Gets the name of the project.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the description of the project.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the file path to the image associated with the project.
        /// </summary>
        public string ImagePath { get; }

        /// <summary>
        /// Gets the list of links associated with the project, such as GitHub repository links, website links, etc.
        /// </summary>
        public List<Link> Links { get; }

        /// <summary>
        /// Gets the list of programming languages used in the project.
        /// </summary>
        public List<ProgrammingLanguage> ProgrammingLanguages { get; }

        /// <summary>
        /// Initializes a new instance of the ProjectInfo class with the specified name, description, image path, links, and programming languages.
        /// </summary>
        /// <param name="name">The name of the project.</param>
        /// <param name="description">The description of the project.</param>
        /// <param name="imagePath">The file path to the image associated with the project.</param>
        /// <param name="links">The list of links associated with the project.</param>
        /// <param name="programmingLanguages">The list of programming languages used in the project.</param>
        public Project(string name, string description, string imagePath, List<Link> links, List<ProgrammingLanguage> programmingLanguages)
        {
            Name = name;
            Description = description;
            ImagePath = imagePath;
            Links = links;
            ProgrammingLanguages = programmingLanguages;
        }
    }
}
