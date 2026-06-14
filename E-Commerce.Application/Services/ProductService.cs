using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Application.DTOs;
using E_Commerce.Application.Interfaces;
using E_Commerce.Domain.Entities;

namespace E_Commerce.Application.Services
{
    public class ProductService

    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }


        public async Task<List<ProductListDto>> GetAllAsync()
        {
            var product = await _repo.GetAllAsync();

            return product.Select(p => new ProductListDto()
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Price = p.Price,
                Stock = p.Stock
            }).ToList();



        }

        public async Task<ProductDetailDto?> GetByIdAsync(int id)
        {
            var p = await _repo.GetByIdAsync(id);

            if (p == null) return null;


            return new ProductDetailDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Stock = p.Stock,
                Description = p.Description,
                CategoryId = p.CategoryId,
                ImageUrl = p.ImageUrl
            };
        }

        public async Task CreateAsync(CreateProductDtos dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                Stock = dto.Stock,
                CategoryId = dto.CategoryId,
                ImageUrl = dto.ImageUrl

            };
            await _repo.AddAsync(product);

        }

        public async Task UpdateAsync(int id , UpdateProductDto dto)
        {
            var product = await _repo.GetByIdAsync(id);

            if (product == null)
                throw new Exception("product not found");

            product.Name = dto.Name;
            product.Description = dto.Description;
            product.Price = dto.Price;
            product.Stock = dto.Stock;
            product.ImageUrl = dto.ImageUrl;

            await _repo.UpdateAsync(product);
        }
        public async Task RemoveAsync(int id)
        {
            var product = await _repo.GetByIdAsync(id);

            if (product == null)
                throw new Exception("Product not found");

            await _repo.DeleteAsync(product);

        }


    }
}






