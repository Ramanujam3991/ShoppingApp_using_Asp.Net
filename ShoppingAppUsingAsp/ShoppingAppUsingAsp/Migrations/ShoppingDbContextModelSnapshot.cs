﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingAppUsingAsp.Models;

namespace ShoppingAppUsingAsp.Migrations
{
    [DbContext(typeof(ShoppingDbContext))]
    partial class ShoppingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShoppingAppUsingAsp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Chocolate Product"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruit Product"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Gummy Product"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Halloween Product"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Hard Product"
                        });
                });

            modelBuilder.Entity("ShoppingAppUsingAsp.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShoppingAppUsingAsp.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ShoppingAppUsingAsp.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Desc = "Goblet of fire",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\thumbnail1.jpg",
                            ImageUrl = "\\Images\\product1.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Harry Potter Book",
                            Price = 15.95m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Desc = "Office Desk comes in different color",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\thumbnail2.jpg",
                            ImageUrl = "\\Images\\product2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "IKEA Office table",
                            Price = 45.95m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            Desc = "Mouth watering traditional snacks",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\thumbnail3.jpg",
                            ImageUrl = "\\Images\\product3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Indian Snacks Combo",
                            Price = 6.75m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 4,
                            Desc = "Antique Piece for sale. May remind you of your childhood.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\thumbnail4.jpg",
                            ImageUrl = "\\Images\\product4.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Nokia 1100",
                            Price = 120.95m
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 5,
                            Desc = "Do you want to impress your girlfriend? Go for this cool jacket",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\thumbnail5.jpg",
                            ImageUrl = "\\Images\\product5.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Denim Jacket",
                            Price = 36.00m
                        });
                });

            modelBuilder.Entity("ShoppingAppUsingAsp.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShopppingCartItems");
                });

            modelBuilder.Entity("ShoppingAppUsingAsp.Models.OrderDetail", b =>
                {
                    b.HasOne("ShoppingAppUsingAsp.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingAppUsingAsp.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShoppingAppUsingAsp.Models.Product", b =>
                {
                    b.HasOne("ShoppingAppUsingAsp.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShoppingAppUsingAsp.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ShoppingAppUsingAsp.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShoppingAppUsingAsp.Models.Category", b =>
                {
                    b.Navigation("Candies");
                });

            modelBuilder.Entity("ShoppingAppUsingAsp.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
