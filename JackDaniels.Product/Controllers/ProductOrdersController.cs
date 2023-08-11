using JackDaniels.Application.InputModels;
using JackDaniels.Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JackDaniels.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOrdersController : ControllerBase
    {
        protected readonly IProductOrderItems _service;

        public ProductOrdersController(IProductOrderItems service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetCode(String code)
        {
            var item = await _service.GetByCode(code);
            if (item is null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductOrderInputModel model)
        {
            var code = await _service.Add(model);

            return CreatedAtAction(
                nameof(GetCode),
                new { code }, model);
        }

    }
}
