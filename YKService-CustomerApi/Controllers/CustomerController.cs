using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace YKService_CustomerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Customer 1", "Customer 2" };
        }
        
    }
}