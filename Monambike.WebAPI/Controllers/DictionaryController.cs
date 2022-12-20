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
    public class DictionaryController : ControllerBase
    {
        private readonly ILogger<DictionaryController> _logger;

        private readonly Services.IDictionaryService _dictionaryService;

        public DictionaryController(Services.IDictionaryService dictionaryService)
        {
            _dictionaryService = dictionaryService;
        }

        public DictionaryController(ILogger<DictionaryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<Dictionary>> GetDictionaryWords() => Ok(_dictionaryService.GetDictionaryWords());
    }
}