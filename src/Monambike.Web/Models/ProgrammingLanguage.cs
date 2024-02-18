namespace Monambike.Web.Models
{
    /// <summary>
    /// Represents a programming language with its name and background color.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ProgrammingLanguage"/> class.
    /// </remarks>
    /// <param name="name">The name of the programming language.</param>
    /// <param name="color">The background color associated with the programming language.</param>
    public class ProgrammingLanguage(string name, string color)
    {
        /// <summary>
        /// Gets the name of the programming language.
        /// </summary>
        public string Name { get; } = name;

        /// <summary>
        /// Gets the background color associated with the programming language.
        /// </summary>
        public string BackgroundColor { get; } = color;
    }
}
