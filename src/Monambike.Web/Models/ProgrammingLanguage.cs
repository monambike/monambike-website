namespace Monambike.Web.Models
{
    /// <summary>
    /// Represents a programming language with its name and background color.
    /// </summary>
    public class ProgrammingLanguage
    {
        /// <summary>
        /// Gets the name of the programming language.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the background color associated with the programming language.
        /// </summary>
        public string BackgroundColor { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgrammingLanguage"/> class.
        /// </summary>
        /// <param name="name">The name of the programming language.</param>
        /// <param name="color">The background color associated with the programming language.</param>
        public ProgrammingLanguage(string name, string color)
        {
            Name = name;
            BackgroundColor = color;
        }
    }
}
