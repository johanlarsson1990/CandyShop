﻿// <auto-generated />
using System;
using Candyshop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Candyshop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Candyshop.Models.Candy", b =>
                {
                    b.Property<int>("CandyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
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

                    b.HasKey("CandyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            CandyId = 1,
                            CategoryId = 1,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy3-small.jpg",
                            ImageUrl = "\\Images\\chocolet.candy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Chocolet Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 2,
                            CategoryId = 1,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy-small.jpg",
                            ImageUrl = "\\Images\\chocolateCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Chocolet Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 3,
                            CategoryId = 1,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy2-small.jpg",
                            ImageUrl = "\\Images\\chocolateCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Chocolet Candy",
                            Price = 2.95m
                        },
                        new
                        {
                            CandyId = 4,
                            CategoryId = 2,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\FruitCandy-small.jpg",
                            ImageUrl = "\\Images\\FruitCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Fruit Candy",
                            Price = 6.95m
                        },
                        new
                        {
                            CandyId = 5,
                            CategoryId = 2,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy2-small.jpg",
                            ImageUrl = "\\Images\\fruitCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Fruit Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 6,
                            CategoryId = 2,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy3-small.jpg",
                            ImageUrl = "\\Images\\fruitCandy3.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Assorted Fruit Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 7,
                            CategoryId = 3,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy-small.jpg",
                            ImageUrl = "\\Images\\gummyCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Gummy Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 8,
                            CategoryId = 3,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy2-small.jpg",
                            ImageUrl = "\\Images\\gummyCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Gummy Candy",
                            Price = 6.95m
                        },
                        new
                        {
                            CandyId = 9,
                            CategoryId = 3,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy3-small.jpg",
                            ImageUrl = "\\Images\\gummyCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Gummy Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 10,
                            CategoryId = 4,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy-small.jpg",
                            ImageUrl = "\\Images\\halloweenCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Halloween Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 11,
                            CategoryId = 4,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy2-small.jpg",
                            ImageUrl = "\\Images\\halloweenCandy2.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Assorted Halloween Candy",
                            Price = 5.95m
                        },
                        new
                        {
                            CandyId = 12,
                            CategoryId = 4,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy3-small.jpg",
                            ImageUrl = "\\Images\\halloweenCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Halloween Candy",
                            Price = 6.95m
                        },
                        new
                        {
                            CandyId = 13,
                            CategoryId = 5,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\hardCandy-small.jpg",
                            ImageUrl = "\\Images\\hardCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Hard Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 14,
                            CategoryId = 5,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\hardCandy2-small.jpg",
                            ImageUrl = "\\Images\\hardCandy2.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Assorted Hard Candy",
                            Price = 2.95m
                        },
                        new
                        {
                            CandyId = 15,
                            CategoryId = 5,
                            Description = " Lorem ipsum dolor sit amet, consectetur adiposcing elit, sed do eiusmod tempor...",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\hardCandy3-small.jpg",
                            ImageUrl = "\\Images\\hardCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Hard Candy",
                            Price = 5.95m
                        });
                });

            modelBuilder.Entity("Candyshop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescriptin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categores");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Chocolate Candy"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruit Candy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Gummy Candy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Halloween Candy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Hard Candy"
                        });
                });

            modelBuilder.Entity("Candyshop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Candyshop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CandyId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CandyId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Candyshop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CandyId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("CandyId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Candyshop.Models.Candy", b =>
                {
                    b.HasOne("Candyshop.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Candyshop.Models.OrderDetail", b =>
                {
                    b.HasOne("Candyshop.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Candyshop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Candyshop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Candyshop.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
