using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastracture.Persistence
{
    public class AppDbContext :DbContext
    {

        public DbSet<Product> Products => Set<Product>();

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
