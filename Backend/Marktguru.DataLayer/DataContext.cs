using System;
using Marktguru.DataLayer.DataEntities;
using Microsoft.EntityFrameworkCore;

namespace Marktguru.DataLayer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<ProductModel> ProductModels => Set<ProductModel>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}