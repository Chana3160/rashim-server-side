using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_rashim.Models;
using test_rashim.Models.Shared;
using test_rashim.Services;

namespace test_rashim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthor _service;
        public AuthorController(IAuthor service) { _service = service; }
        [HttpGet]
       public async Task<List<AuthorShared>> GetAuthors()
        {
            return await _service.GetAuthors();
        }
        [HttpGet("{id}")]
        public async Task<AuthorShared?> GetAuthorById(string id)
        {
            return await _service.GetAuthorById(id);
        }
       

    }
}
