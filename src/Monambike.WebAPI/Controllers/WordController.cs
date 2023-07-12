using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Monambike.WebAPI.DTOs.Dictionary;
using System.Linq;
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
        public async Task<ActionResult<ServiceResponse<GetWordDTO>>> Get() => Ok(await _wordService.GetWords());

        //[HttpGet("{WordID}")]
        //public async Task<ActionResult<Word>> Get(int id) => Ok(await _wordService.GetWord());

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetWordDTO>>> Create(CreateWordDTO newWord)
        {
            var serviceResponse = await _wordService.CreateWord(newWord);
            if (serviceResponse.Success)
            {
                return CreatedAtAction(nameof(Get), new { id = serviceResponse.Data.Id }, serviceResponse);
            }

            return BadRequest(serviceResponse);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceResponse<UpdateWordDTO>>> Update(int id, UpdateWordDTO updatedWord)
        {
            var serviceResponse = await _wordService.UpdateWord(id, updatedWord);
            if (serviceResponse.Success)
            {
                return Ok(serviceResponse);
            }

            return BadRequest(serviceResponse);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<string>>> Delete(int id)
        {
            var serviceResponse = await _wordService.DeleteWord(id);
            if (serviceResponse.Success)
            {
                return Ok(serviceResponse);
            }

            return BadRequest(serviceResponse);
        }

    }
}