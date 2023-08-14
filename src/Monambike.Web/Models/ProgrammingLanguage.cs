namespace Monambike.Web.Models
{
    public class ProgrammingLanguage
    {
        public string Name { get; }

        public string Color { get; }

        public ProgrammingLanguage(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public static ProgrammingLanguage Monambike => new("C#", "green");
    }
}
