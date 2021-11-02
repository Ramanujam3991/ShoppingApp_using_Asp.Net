using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAppUsingAsp.Models
{
    public class ShoppingDbContext : IdentityDbContext<IdentityUser>
    {

        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options) :
            base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShopppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Book" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Table" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Snacks" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Mobile" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Dress" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Harry Potter Book",
                Price = 15.95M,
                Desc = "Goblet of fire",
                CategoryId = 1,
                ImageUrl = "\\Images\\product1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\thumbnail1.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "IKEA Office table",
                Price = 45.95M,
                Desc = "Office Desk comes in different color",
                CategoryId = 2,
                ImageUrl = "\\Images\\product2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\thumbnail2.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Indian Snacks Combo",
                Price = 6.75M,
                Desc = "Mouth watering traditional snacks",
                CategoryId = 3,
                ImageUrl = "\\Images\\product3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\thumbnail3.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Nokia 1100",
                Price = 120.95M,
                Desc = "Antique Piece for sale. May remind you of your childhood.",
                CategoryId = 4,
                ImageUrl = "\\Images\\product4.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\thumbnail4.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Denim Jacket",
                Price = 36.00M,
                Desc = "Do you want to impress your girlfriend? Go for this cool jacket",
                CategoryId = 5,
                ImageUrl = "\\Images\\product5.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\thumbnail5.jpg",
                IsInStock = true,
                IsOnSale = true
            });

        }
    }
}
