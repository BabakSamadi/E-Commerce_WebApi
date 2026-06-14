using E_Commerce.Application.DTOs;
using E_Commerce.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _Services;

        public ProductController(ProductService services)
        {
            _Services = services;
        }


        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _Services.GetAllAsync();

            return Ok(result);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result =  await _Services.GetByIdAsync(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> create(CreateProductDtos dto)
        {
            await _Services.CreateAsync(dto);
            return Ok(dto);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateProductDto dto)
        {
            await _Services.UpdateAsync(id,dto);
            return Ok(dto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _Services.RemoveAsync(id);
            return Ok("productDelete");

        }

    }
}
