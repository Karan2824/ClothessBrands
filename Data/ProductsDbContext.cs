using ClothessBrands.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothessBrands.Data
{
    public class ProductsDbContext : DbContext
    {
        // Here we add in all the tables we are using.
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Orders> Orders { get; set; }
        // We need 2 constructors, one is empty, and the other injects in DbContextOptions
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
        : base(options)
        {
        }
        public ProductsDbContext()
        {
        }
    }
}
