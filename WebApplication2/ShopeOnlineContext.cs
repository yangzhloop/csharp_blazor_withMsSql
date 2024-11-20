using System.Collections.Generic;
using Demo.Api;
using Microsoft.EntityFrameworkCore;
using ShopOnlineApi.Models;

namespace ShopOnlineApi.Data
{
    public class ShopOnlineContext : DbContext
    {
        public ShopOnlineContext(DbContextOptions<ShopOnlineContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

    }
}
