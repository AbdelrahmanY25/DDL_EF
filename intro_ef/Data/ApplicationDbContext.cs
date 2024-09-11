using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using intro_ef.Models;

namespace intro_ef.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=localhost;" +
                                        "Initial Catalog=Sales_Database;" +
                                        "Integrated Security=True;" +
                                        "TrustServerCertificate=True");

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(
                cs =>
                {
                    cs.Property(c => c.Email).HasColumnType("varchar(100)");
                });

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Customers)
                .WithMany(e => e.Products);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Stores)
                .WithMany(e => e.Products);
        }
    }
}
