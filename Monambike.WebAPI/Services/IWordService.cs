using System.Collections.Generic;
using Monambike.WebAPI.Models.Dictionary;

namespace Monambike.WebAPI.Services
{
    public interface IWordService
    {
        public IEnumerable<Word> GetWords();
    }
}
