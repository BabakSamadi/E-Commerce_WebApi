using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Domain.Entities;

namespace E_Commerce.Application.DTOs
{
    public class CartDto
    {
        public List<CartItemDto> Items { get; set; } = new();

        public decimal TotalPrice { get; set; }
    }
}
