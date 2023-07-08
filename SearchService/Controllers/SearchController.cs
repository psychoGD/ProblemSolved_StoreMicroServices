using Microsoft.AspNetCore.Mvc;
using SearchService.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SearchService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchRepository _searchRepository;

        public SearchController(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }

        // GET api/<SearchController>/5
        [HttpGet("{code}")]
        public IActionResult Get(string code)
        {
            try
            {
                var item = _searchRepository.Get(code);
                if (item == null)
                {
                    return BadRequest();
                }
                return Ok(item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
