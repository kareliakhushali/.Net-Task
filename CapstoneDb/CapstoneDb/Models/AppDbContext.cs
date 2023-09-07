using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneDb.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
    
        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Product> Products  { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Mobile" });
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory() { CatId = 1, Name = "Android", Id = 1 });
            modelBuilder.Entity<Product>().HasData(
            new Product() { Id = 1, Name = "Oppo", Qty = 10, Rate = 17000, Profile = "oppo.jpg", IsActive = true, CatId = 16, SubId = 20, Brand = "Redmi", Generation = "4g", Color = "Black", Sims = 2, OS = "11", RAM = 6, ROM = 64 });



        }
    }
}
