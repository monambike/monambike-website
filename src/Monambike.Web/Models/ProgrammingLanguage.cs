namespace Monambike.Web.Models
{
    public class ProgrammingLanguage
    {
        public string Name { get; }

        public string BackgroundColor { get; }

        public ProgrammingLanguage(string name, string color)
        {
            Name = name;
            BackgroundColor = color;
        }

        public static ProgrammingLanguage CSharp => new("C#", "#7318f2"); // Purple
        public static ProgrammingLanguage HTML => new("HTML", "#17bdff"); // Cyan Blue
        public static ProgrammingLanguage JavaScript => new("JavaScript", "#eafc23"); // Yellow
    }
}
