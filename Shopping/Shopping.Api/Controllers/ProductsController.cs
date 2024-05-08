using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.Api.Models;
using Shopping.Client.Data;

namespace Shopping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(ProductContext context, ILogger<ProductsController> logger) : ControllerBase
    {
        private readonly ProductContext _context = context;
        private readonly ILogger<ProductsController> _logger = logger;

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAsync()
        {
            return await _context
                .Products
                .Find(p => true)
                .ToListAsync();
        }
    }
}
