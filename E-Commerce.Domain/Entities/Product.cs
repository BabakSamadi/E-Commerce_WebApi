using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Domain.Common;

namespace E_Commerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get;  set; } = string.Empty;

        public decimal Price { get; set; }

        public int Stock { get;  set; }

        public string Description { get;  set; }

        public int CategoryId { get;  set; }

        public string ImageUrl { get; set; } = string.Empty;



    }
}
