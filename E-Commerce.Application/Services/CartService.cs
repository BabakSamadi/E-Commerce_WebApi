using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Application.DTOs;
using E_Commerce.Application.Interfaces;
using E_Commerce.Domain.Entities;

namespace E_Commerce.Application.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public async Task AddToCartAsync(AddToCartDto dto)
        {
            
            var cart = await _cartRepository.GetCartAsync();

            
            if (cart == null)
            {
                cart = new Cart();
                await _cartRepository.CreateCartAsync(cart);
                await _cartRepository.SaveChangesAsync();
            }

           

         
            var exsistingItem = cart.CartItem.FirstOrDefault(x => x.ProductId == dto.ProductId);

            if (exsistingItem != null)
            {
               
                exsistingItem.Quantity += dto.Quantity;
                await _cartRepository.UpdateItemAsync(exsistingItem);
            }
            else
            {
                
                var newItem = new CartItem
                {
                    CartId = cart.Id,
                    ProductId = dto.ProductId,
                    Quantity = dto.Quantity
                };

                await _cartRepository.AddItemAsync(newItem);
            }

            
            await _cartRepository.SaveChangesAsync();
        }

        public async Task<CartDto> GetCartAsync()
        {
            var cart = await _cartRepository.GetCartAsync();

            if (cart == null) return new CartDto();


            var itemDtos = cart.CartItem.Select(x => new CartItemDto
            {
                ProductId = x.ProductId,
                ProductName = x.Product != null ? x.Product.Name : "نامشخص",
                Price = x.Product != null ? x.Product.Price : 0,
                Quantity = x.Quantity,

            }).ToList();

            decimal total = itemDtos.Sum(item => item.Price * item.Quantity);

            return new CartDto
            {
                Items = itemDtos,
                TotalPrice = total
            };
        }

        public async Task RemoveItemAsync(int itemId)
        {
            await _cartRepository.RemoveItemAsync(itemId);
            await _cartRepository.SaveChangesAsync();
        }

        public async Task UpdateQuantityAsync(int itemId, UpdateCartItemDto dto)
        {
            
            var cart = await _cartRepository.GetCartAsync();
            var item = cart?.CartItem.FirstOrDefault(x => x.Id == itemId);

            if (item != null)
            {
                item.Quantity = dto.Quantity;
                await _cartRepository.UpdateItemAsync(item);
                await _cartRepository.SaveChangesAsync();
            }
        }
    }
}
