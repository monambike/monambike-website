
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Threading.Tasks;
using Monambike.WebAPI.Data;

namespace Monambike.WebAPI.Services.Dictionary
{
    public class WordService : IWordService
    {
        private readonly IMapper _mapper;
        public WordService(IMapper mapper  )
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<GetWordDTO>>> GetWord()
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
    }
}
