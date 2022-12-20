using System.Collections.Generic;
using Monambike.WebAPI.Models.Dictionary;

namespace Monambike.WebAPI.Services
{
    public interface IDictionaryService
    {
        public IEnumerable<Dictionary> GetDictionaryWords();
    }
}
