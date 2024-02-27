namespace Monambike.Web.Models
{
    public class Curiosity
    {
        public List<string> Curiosities { get; set; } = new List<string>();

        /// <summary>
        /// The curiosities file path.
        /// </summary>
        public StreamReader CuriositiesFile = new(@"..\Resources\Curiosities.txt");

        public Curiosity()
        {
            // Reads every line until the end of curiosities file
            while (!CuriositiesFile.EndOfStream)
            {
                // Getting the line
                var line = CuriositiesFile.ReadLine();
                // If the line is not null, add into the list
                if (line is not null) Curiosities.Add(line);
            }
        }

        private string GetRandomCuriosity() => Curiosities[new Random().Next(1, Curiosities.Count)];
    }
}
