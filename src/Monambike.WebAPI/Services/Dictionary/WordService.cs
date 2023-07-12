using Monambike.WebAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monambike.WebAPI.Services.Dictionary
{
    public class WordService : IWordService
    {
        private readonly IMapper _mapper;
        public WordService(IMapper mapper  )
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<GetWordDTO>>> GetWords()
        {
            using (var context = new MonambikeContext())
            {
                var query = context.Words;
            }

            var serviceResponse = new ServiceResponse<IEnumerable<GetWordDTO>>();
            
            var words = new ServiceResponse<IEnumerable<GetWordDTO>>();
            serviceResponse.Data = _mapper.Map<IEnumerable<GetWordDTO>>(words.Data);

            if (serviceResponse.Data.Any())
                return serviceResponse;

            throw new Exception("No words were found.");
        }
        public async Task<ServiceResponse<GetWordDTO>> CreateWord(CreateWordDTO newWord)
        {
            var wordEntity = _mapper.Map<Word>(newWord);

            using (var context = new MonambikeContext())
            {
                context.Words.Add(wordEntity);
                await context.SaveChangesAsync();
            }

            var createdWordDto = _mapper.Map<GetWordDTO>(wordEntity);
            return new ServiceResponse<GetWordDTO> { Data = createdWordDto };
        }
        public async Task<ServiceResponse<UpdateWordDTO>> UpdateWord(int id, UpdateWordDTO updatedWord)
        {
            var existingWord = _mapper.Map<Word>(updatedWord);
            using (var context = new MonambikeContext())
            {
                existingWord = await context.Words.FindAsync(id);
                if (existingWord == null)
                    throw new Exception("Word not found.");

                _mapper.Map(updatedWord, existingWord);
                await context.SaveChangesAsync();
            }

            var updatedWordDto = _mapper.Map<UpdateWordDTO>(existingWord);
            return new ServiceResponse<UpdateWordDTO> { Data = updatedWordDto };
        }

        public async Task<ServiceResponse<string>> DeleteWord(int id)
        {

            using (var context = new MonambikeContext())
            {
                var existingWord = await context.Words.FindAsync(id);
                if (existingWord == null)
                    throw new Exception("Word not found.");

                context.Words.Remove(existingWord);
                await context.SaveChangesAsync();
            }

            return new ServiceResponse<string> { Data = "Word deleted successfully." };
        }
    }
}
