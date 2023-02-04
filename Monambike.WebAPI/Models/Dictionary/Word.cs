using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Dictionary
{
    public class Word
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Meanings { get; set; }

        //public List<Word> Antonyms { get; set; }

        //public List<Word> Synonyms { get; set; }
    }
}
