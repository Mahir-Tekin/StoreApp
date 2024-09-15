using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Concrete
{
    public class StoreAppDbContext : DbContext
    {
        public StoreAppDbContext(DbContextOptions<StoreAppDbContext> options) : base(options)
        {
            
        }

        DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                    new List<Product>()
                    {
                        new Product { Id = 1,Name="samsung s24", Price=50000,Description="güzel telefon", Category="Telefon" },
                        new Product { Id = 2,Name="samsung s25", Price=50000,Description="güzel telefon", Category="Telefon" },
                        new Product { Id = 3,Name="samsung s267", Price=50000,Description="güzel telefon", Category="Telefon" },
                        new Product { Id = 4,Name="samsung s244", Price=50000,Description="güzel telefon", Category="Telefon" },
                        new Product { Id = 5,Name="samsung s245", Price=50000,Description="güzel telefon", Category="Telefon" },
                    }
                );
        }
    }
}
