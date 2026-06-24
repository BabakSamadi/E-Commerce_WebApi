using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.Infrastracture.Mapping
{
    public class CartMapping : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
           
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.CartItem)
                .WithOne(x => x.Cart)
                .HasForeignKey(x => x.CartId);

        }
    }
}
