using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_rashim.Models.Shared;
using test_rashim.Services;

namespace test_rashim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitleController : ControllerBase
    {
        private readonly ITitle _service;
        public TitleController(ITitle service) { _service = service; }

        [HttpGet("{id}")]
        public async Task<List<TitleShared>> GetTitles(string id)
        {
            return await _service.GetTitles(id);
        }
    }
}
