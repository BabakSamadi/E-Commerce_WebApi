using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.DTOs
{
    public class UpdateProductDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Range(0, 1000000)]
        public Decimal Price { get; set; }

        [Range(0, 10000)]
        public int Stock { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public int CategoryId { get; set; }
    }
}
