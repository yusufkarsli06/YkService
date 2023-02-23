using Microsoft.AspNetCore.Mvc;

namespace YKService_Product.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Product 1 ", "Product 2" };
        }


    }
}