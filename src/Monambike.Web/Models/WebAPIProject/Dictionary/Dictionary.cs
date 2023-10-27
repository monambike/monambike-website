using System.Collections.ObjectModel;

namespace Common.WebAPI
{
    public class Dictionary
    {
        public Collection<Word> Words { get; set; }
    }

    public class Word
    {
        public string Name { get; set; }

        public Collection<Meaning> Meanings { get; set; }
    }

    public class Meaning
    {
        public string Description { get; set; }
    }
}
