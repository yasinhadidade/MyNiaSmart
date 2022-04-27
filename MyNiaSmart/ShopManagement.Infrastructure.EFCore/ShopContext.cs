﻿using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductBrandAgg;
using ShopManagement.Domain.ProductModelAgg;
using ShopManagement.Domain.ProductStatusAgg;
using ShopManagement.Domain.ProductTypeAgg;
using ShopManagement.Domain.ProductUsageTypeAgg;
using ShopManagement.Infrastructure.EFCore.Mapping;

namespace ShopManagement.Infrastructure.EFCore
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<ProductBrand> ProductBrands{ get; set; }
        public DbSet<ProductModel> ProductModels{ get; set; }
        public DbSet<ProductStatus> ProductStatuses{ get; set; }
        public DbSet<ProductType> ProductTypes{ get; set; }
        public DbSet<ProductUsageType> ProductUsageTypes{ get; set; }

        public ShopContext(DbContextOptions<ShopContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
