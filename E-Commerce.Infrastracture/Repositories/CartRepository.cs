using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Application.Interfaces;
using E_Commerce.Domain.Entities;
using E_Commerce.Infrastracture.Persistence;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastracture.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly AppDbContext _appDbContext;

        public CartRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task AddItemAsync(CartItem item)
        {
           await _appDbContext.CartItems.AddAsync(item);
        }

        public async Task CreateCartAsync(Cart cart)
        {
            await _appDbContext.Carts.AddAsync(cart);
        }

        public async Task<Cart?> GetCartAsync()
        {
            return await _appDbContext.Carts
                .Include(x => x.CartItem)
                .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync();
        }

        public async Task RemoveItemAsync(int ItemId)
        {
            var item = await _appDbContext.CartItems.FindAsync(ItemId);

            if (item != null)
            {
                _appDbContext.CartItems.Remove(item);
            }


        }

        public async Task SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }

        public Task UpdateItemAsync(CartItem item)
        {
            _appDbContext.CartItems.Update(item);

            return Task.CompletedTask; 
        }
    }
}
