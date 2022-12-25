using Monambike.WebAPI.Models.Dictionary;
using System.Collections.Generic;
using System.Linq;

namespace Monambike.WebAPI.Services
{
    public class WordService : IWordService
    {
        public IEnumerable<Word> GetWords() => new List<Word>().AsEnumerable();
    }
}
