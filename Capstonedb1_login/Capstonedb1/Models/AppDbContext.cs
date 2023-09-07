using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstonedb1.Models
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Register> Registrations { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                 new Category() { Id = 1, Name = "Mobiles" },
                 new Category() { Id = 2, Name = "Laptop" });
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory() { Id = 1, Name = "Apple", CatId = 1 },
                new SubCategory() { Id = 2, Name = "Samsung", CatId = 1 },
                new SubCategory() { Id = 3, Name = "Oneplus", CatId = 1 },
                new SubCategory() { Id = 4, Name = "Asus", CatId = 2 },
                new SubCategory() { Id = 5, Name = "HP", CatId = 2 },
                new SubCategory() { Id = 6, Name = "Dell", CatId = 2 });
            modelBuilder.Entity<Product>().HasData(
           new Product() { Id = 1, Name = "Oppo", Qty = 10, Rate = 17000, Profile = "oppo.jpg", IsActive = true, CatId = 16, SubId = 20, Brand = "Redmi", Generation = "4g", Color = "Black", Sims = 2, OS = "11", RAM = 6, ROM = 64 });
            modelBuilder.Entity<Register>().HasData(
         new Register() { Id = 1, Username = "khushi", Email = "khushi@gmail.com", Password = "khushi@khushi" });
        }
    }
}
