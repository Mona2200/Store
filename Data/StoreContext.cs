using Microsoft.EntityFrameworkCore;
using Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data
{
   public class StoreContext : DbContext
   {
      public DbSet<Product> Products { get; set; }
      public DbSet<Review> Reviews { get; set; }
      public DbSet<User> Users { get; set; }

      public StoreContext(DbContextOptions<StoreContext> options) : base(options)
      {
         //Database.EnsureCreated();
         Database.Migrate();
      }

      protected override void OnModelCreating(ModelBuilder builder)
      {
         builder.Entity<Product>().ToTable("Products");
         builder.Entity<Review>().ToTable("Reviews");
         builder.Entity<User>().ToTable("Users");
      }
   }
}
