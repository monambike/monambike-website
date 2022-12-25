using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Monambike.WebAPI.Models.Dictionary;

namespace Monambike.WebAPI.Services
{
    public class WordService : IWordService
    {
        public IEnumerable<Word> GetWords() => new List<Word>().AsEnumerable();
    }
}
