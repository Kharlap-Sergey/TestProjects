using Catalog.Data.Abstract;
using Catalog.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IProductRepository ProductRepository { get; }

        public ProductsController(
            IProductRepository productRepository
            )
        {
            ProductRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(string? category = null)
        {
            if(category == null)
                return Ok(await ProductRepository.GetProductsAsync());

            return Ok(await ProductRepository.GetProductsByCategoryAsync(category));
        }

        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var p = await ProductRepository.GetProductByIdAsync(id);
            return p != null ? Ok(p) : NotFound();

        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            await ProductRepository.CreateProuctAsync(product);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var res = await ProductRepository.UpdateProductAsync(product);

            return res ? Ok() : BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> CreateProduct(string id)
        {
            var res = await ProductRepository.DeleteProductAsync(id);

            return res ? Ok() : BadRequest();
        }
    }
}
