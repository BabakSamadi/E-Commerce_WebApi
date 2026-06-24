using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Application.DTOs;
using E_Commerce.Domain.Entities;

namespace E_Commerce.Application.Services
{
    public interface ICartService
    {
        Task AddToCartAsync(AddToCartDto dto);

        Task RemoveItemAsync(int itemId);

        Task UpdateQuantityAsync(
            int itemId,
            UpdateCartItemDto dto);

        Task<CartDto> GetCartAsync();
    }
}
