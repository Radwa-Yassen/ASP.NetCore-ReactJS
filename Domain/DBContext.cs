using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductsData> ProductsData { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductsData>()
                .HasIndex(u => u.ProductId)
                .IsUnique();
        }
    }
}
