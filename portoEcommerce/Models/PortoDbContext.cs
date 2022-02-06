using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porto_ecommerce_30_.Models
{
    public class PortoDbContext:DbContext
    {
        public PortoDbContext(DbContextOptions<PortoDbContext> options) : base(options){ }
        public DbSet<Category> categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Slider>().HasData(
            new Slider { Id = 1, Image = "slide1.jpg", ClothType = "on Jackets", Discount = "get up 30%", Price = 199, TrendWord = "winter clothes" },
            new Slider { Id = 2, Image = "slide2.jpg", ClothType = "on Coat", Discount = "get up 30%", Price = 199, TrendWord = "Season clothes" }
            );
        }
    }
}
