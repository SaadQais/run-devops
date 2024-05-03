using Microsoft.AspNetCore.Mvc;
using Shopping.Api.Models;
using Shopping.Client.Data;

namespace Shopping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(ILogger<ProductsController> logger) : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger = logger;

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductContext.Products;
        }
    }
}
