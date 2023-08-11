using JackDaniels.Application.Services;
using Microsoft.AspNetCore.Mvc;


namespace JackDaniels.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        protected readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAll();

            if (products is null)
                return NotFound();

            return Ok(products);
        }

    }
}
