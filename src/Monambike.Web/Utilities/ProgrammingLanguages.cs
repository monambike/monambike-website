using Monambike.Web.Models;

namespace Monambike.Web.Utilities
{
    public class ProgrammingLanguages
    {
        /// <summary>
        /// Represents the C# programming language with its name and purple background color.
        /// </summary>
        public static ProgrammingLanguage CSharp => new("C#", "#7318f2"); // Purple

        /// <summary>
        /// Represents the HTML programming language with its name and cyan blue background color.
        /// </summary>
        public static ProgrammingLanguage HTML => new("HTML", "#17bdff"); // Cyan Blue

        /// <summary>
        /// Represents the JavaScript programming language with its name and yellow background color.
        /// </summary>
        public static ProgrammingLanguage JavaScript => new("JavaScript", "#eafc23"); // Yellow
    }
}
