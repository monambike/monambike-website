using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Monambike.WebAPI.Models.Dictionary;
using Monambike.WebAPI.Services;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Monambike.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordController : ControllerBase
    {
        private readonly ILogger<WordController> _logger;

        private readonly Services.IWordService _wordService;

        public WordController(Services.IWordService wordService)
        {
            _wordService = wordService;
        }

        public WordController(ILogger<WordController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<Word>> GetDictionaryWords() => Ok(_wordService.GetWords());
    }
}