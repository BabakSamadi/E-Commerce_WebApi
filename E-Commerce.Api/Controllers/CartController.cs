using E_Commerce.Application.DTOs;
using E_Commerce.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }


        [HttpGet]
        public async Task<ActionResult<CartDto>> GetCart()
        {
            var cart = await _cartService.GetCartAsync();

            return Ok(cart);
        }


        [HttpPost("items")]
        public async Task<IActionResult> AddCartDto([FromBody] AddToCartDto dto)
        {
            await _cartService.AddToCartAsync(dto);

            return Ok(new {Message = " محصول با موفقیت به سبد خرید اضافه شد "});

        }

        [HttpPut("items/{itemId}")]
        public async Task<IActionResult> UpdateQuntity(int ItemId, [FromBody] UpdateCartItemDto dto)
        {
            await _cartService.UpdateQuantityAsync(ItemId, dto);

            return NoContent();
        }


        [HttpDelete("items/{itemId}")]
        public async Task<IActionResult> RemoveItem(int ItemId)
        {
            await _cartService.RemoveItemAsync(ItemId);
            return NoContent();
        }


    }
}
