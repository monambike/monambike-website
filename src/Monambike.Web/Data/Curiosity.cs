namespace Monambike.Web.Data
{
    public class Curiosity
    {
        public List<string> Curiosities { get; set; } = new List<string>();

        public StreamReader CuriositiesFile = new(@"..\Resources\Curiosities.txt");

        public Curiosity()
        {
            while (!CuriositiesFile.EndOfStream)
            {
                var line = CuriositiesFile.ReadLine();
                if (line is not null) Curiosities.Add(line);
            }
        }

        private string GetRandomCuriosity()
        {
            var random = new Random();
            return Curiosities[random.Next(1, Curiosities.Count)];
        }
    }
}
