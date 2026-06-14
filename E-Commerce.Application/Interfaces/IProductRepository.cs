using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Domain.Entities;

namespace E_Commerce.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();

        Task<Product?> GetByIdAsync(int id);

        Task AddAsync(Product  product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Product  product);

        Task SaveChanges();

    }
}
