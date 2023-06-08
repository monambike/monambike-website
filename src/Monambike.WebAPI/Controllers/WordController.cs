using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Monambike.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WordController : ControllerBase
    {
        private readonly IWordService _wordService;

        public WordController(IWordService wordService, ILogger<WordController> logger) => _wordService = wordService;

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<GetWordDTO>>> Get() => Ok(await _wordService.GetWord());

        //[HttpGet("{WordID}")]
        //public async Task<ActionResult<Word>> Get(int id) => Ok(await _wordService.GetWord());
    }
}