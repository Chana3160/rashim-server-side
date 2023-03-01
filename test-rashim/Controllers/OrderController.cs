using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_rashim.Models.Shared;
using test_rashim.Models;
using test_rashim.Services;

namespace test_rashim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase { 
        private readonly IOrder _service;
   public OrderController(IOrder service) { _service= service; }
    
        [HttpPost]
        public async Task<List<Order>> CreateTask(TitleShared[] order)
        {
            return await _service.CreateTask(order);
        }
    }
}
