using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Monambike.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DictionaryController : ControllerBase
    {
        private readonly ILogger<DictionaryController> _logger;

        public DictionaryController(ILogger<DictionaryController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDictionary")]
        public IEnumerable<Data.Dictionary> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Data.Dictionary
            {
                Words = new List<Data.Word>()
            })
            .ToArray();
        }
    }
}