// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: contact@monambike.com for more information.
// For license information, please see the LICENSE file in the root directory.
namespace Monambike.Web.Models
{
    public class RandomPhrase
    {
        public List<string> Phrases { get; set; } = [];

        /// <summary>
        /// The phrases file path.
        /// </summary>
        public StreamReader PhrasesFile = new(@"..\Resources\Phrases.txt");

        public RandomPhrase()
        {
            // Reads every line until the end of phrases file
            while (!PhrasesFile.EndOfStream)
            {
                // Getting the line
                var line = PhrasesFile.ReadLine();
                // If the line is not null, add into the list
                if (line is not null) Phrases.Add(line);
            }
        }

        private string GetRandomPhrases() => Phrases[new Random().Next(1, Phrases.Count)];
    }
}
