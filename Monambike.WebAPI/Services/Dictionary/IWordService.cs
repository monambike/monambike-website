using System.Collections.Generic;
using System.Threading.Tasks;

namespace Monambike.WebAPI.Services.Dictionary
{
    public interface IWordService
    {
        public Task<ServiceResponse<IEnumerable<GetWordDTO>>> GetWord();
        //public IEnumerable<Word> GetWord(int id);
        //public IEnumerable<Word> GetWord(string name);
        //public IEnumerable<Word> RenameWord(int id, string newName);
        //public IEnumerable<Word> RenameWord(string oldName, string newName);
        //public IEnumerable<Word> DeleteWord(int id);
        //public IEnumerable<Word> DeleteWord(string name);
    }
}
