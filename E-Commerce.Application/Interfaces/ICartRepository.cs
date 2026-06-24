using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Domain.Entities;

namespace E_Commerce.Application.Interfaces
{
    public interface ICartRepository
    {
        Task<Cart?> GetCartAsync();

        Task AddItemAsync(CartItem item);
        Task CreateCartAsync(Cart cart);

        Task UpdateItemAsync (CartItem  item);

        Task RemoveItemAsync(int ItemId);

        Task SaveChangesAsync();
        
    }
}
