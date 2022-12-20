using System.Collections.Generic;
using System.Linq;
using Monambike.WebAPI.Models.Dictionary;

namespace Monambike.WebAPI.Services
{
    public class DictionaryService : IDictionaryService
    {
        public IEnumerable<Dictionary> GetDictionaryWords()
        {
            return Enumerable.Range(1, 5).Select(index => new Dictionary
            {
                Words = new List<Word>()
            }).ToArray();
        }
    }
}
