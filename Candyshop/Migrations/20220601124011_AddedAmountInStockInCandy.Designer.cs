﻿// <auto-generated />
using System;
using Candyshop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Candyshop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220601124011_AddedAmountInStockInCandy")]
    partial class AddedAmountInStockInCandy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("AmountInStock")
                        .HasColumnType("int");

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

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CandyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            CandyId = 1,
                            AmountInStock = 0,
                            CategoryId = 1,
                            Description = " Choklad fyllda praliner",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Lindt-choklad-praliner-small.jpg",
                            ImageUrl = "\\Images\\Lindt-choklad-praliner.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Lindt Choklad Praliner",
                            Price = 4.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 2,
                            AmountInStock = 0,
                            CategoryId = 1,
                            Description = " Chokladgodisarnas drottning och lösviktsgodisets tungviktare. Geisha är älskad av generationer och kommer så att vara under en lång tid framöver. Den mjuka chokladen och den nötiga karaktären gifter sig i munnen och tillfredsställer ditt chokladbegär likt ingenting annat.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\geisha-small.jpg",
                            ImageUrl = "\\Images\\geisha.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Geisha Choklad",
                            Price = 3.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 3,
                            AmountInStock = 0,
                            CategoryId = 1,
                            Description = " Halvmånar med smak av apelsinchoklad",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\romerskabagar-small.jpg",
                            ImageUrl = "\\Images\\romerskabagar.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Romerska Bågar",
                            Price = 2.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 4,
                            AmountInStock = 0,
                            CategoryId = 2,
                            Description = " Persikor är ju inte bara en fantastiskt god frukt, det är också en magisk godis. Det är mångas favorit som alltid slinker ner i lördagspåsen och förgyller både dagar, kvällar och nätter. En trogen vapendragare helt enkelt!",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\persiker-small.jpg",
                            ImageUrl = "\\Images\\persiker.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Persikor",
                            Price = 6.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 5,
                            AmountInStock = 0,
                            CategoryId = 2,
                            Description = " I en perfekt mix av sött och surt så är dessa vattenmeloner ett måste i livsnjutarens godisskål! De är redan en klassiker bland lösviktsgodiset, och nu kan du njuta ännu mer av dem med en hel påse av godiset.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\vattenmelon-small.jpg",
                            ImageUrl = "\\Images\\vattenemelon.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Vattenmelon",
                            Price = 3.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 6,
                            AmountInStock = 0,
                            CategoryId = 2,
                            Description = " När det kommer till klassisk konfektyr så blir det knappast bättre än det supersmarriga geléhallonet! Se till att ladda upp med en påse eller två innan helgen stundar.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\gelehallon-small.jpg",
                            ImageUrl = "\\Images\\gelehallon.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Geléhallon",
                            Price = 4.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 7,
                            AmountInStock = 0,
                            CategoryId = 3,
                            Description = " Sura godistungor med smak av frukt. Perfekt till lördagsgodiset eller kalaset!",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\surtunga-small.jpg",
                            ImageUrl = "\\Images\\surtunga.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Suratungor",
                            Price = 4.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 8,
                            AmountInStock = 0,
                            CategoryId = 3,
                            Description = " Minidynamit Sur Vattenmelon från Karamello. Sursockrat godis med smak av vattenmelon.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\survattenmelon-small.jpg",
                            ImageUrl = "\\Images\\survattenmelon.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Sur Vattenmelon",
                            Price = 6.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 9,
                            AmountInStock = 0,
                            CategoryId = 3,
                            Description = " En minivariant av de populära Fizzypop-flaskorna.Mjuk konsistens och god bubbelgumsmak.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fizzypop-small.jpg",
                            ImageUrl = "\\Images\\fizzypop.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Fizzypop",
                            Price = 4.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 10,
                            AmountInStock = 0,
                            CategoryId = 4,
                            Description = " Tack och hej, ditt gamla violsnask. Här är Ultra Violet! Saltlakrits med vit choklad, viol och salmiak.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Ultra-Violet-small.jpg",
                            ImageUrl = "\\Images\\Ultra-Violet.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Ultra Violet",
                            Price = 3.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 11,
                            AmountInStock = 0,
                            CategoryId = 4,
                            Description = " Världens. Saltaste. Lakrits. Vågar du? Lakrits- och salmiakkräm omgiven av salmiaklakrits och salmiak.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\svenskjavlar-small.jpg",
                            ImageUrl = "\\Images\\svenskjavlar.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Svenskjävlar",
                            Price = 5.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 12,
                            AmountInStock = 0,
                            CategoryId = 4,
                            Description = " Salmiak pastilles with a strong taste of salmiak.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\lakrisal-small.jpg",
                            ImageUrl = "\\Images\\lakrisal.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Lakrisal",
                            Price = 6.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 13,
                            AmountInStock = 0,
                            CategoryId = 5,
                            Description = " Njut av klassikern i karamellform, tillverkad i vår anrika karamellfabrik i Hudiksvall",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\polka-small.jpg",
                            ImageUrl = "\\Images\\polka.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Polkagrisar",
                            Price = 3.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 14,
                            AmountInStock = 0,
                            CategoryId = 5,
                            Description = " Äntligen finns våra populära tomteklubbor med fruktsmak! De finns i fem olika färger och säljes osorterat (det blir alltså en överraskning vilken du får).",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\tomteklubbor-small.jpg",
                            ImageUrl = "\\Images\\tomteklubbor.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Tomteklubbor",
                            Price = 2.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 15,
                            AmountInStock = 0,
                            CategoryId = 5,
                            Description = " Kanske såg du dessa godingar i kiosken när du var liten och köpte ditt lördagsgodis? En gammal favorit med en fantastisk smak av salmiak, anis och lakrits. Karamellen har ett brunt lager av salt på utsidan, oförklarligt god med ett surt pulver inne i mitten!",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\kameleonter-small.jpg",
                            ImageUrl = "\\Images\\kamaleonter.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Kameleonter",
                            Price = 5.95m,
                            SalesPrice = 0m
                        },
                        new
                        {
                            CandyId = 16,
                            AmountInStock = 0,
                            CategoryId = 4,
                            Description = " Lakritschips på riktigt!  VARNING! Det är svårt att sluta stoppa dessa chips i munnen när smaklökarna vant sig efter krocken av salta chips och söt lakrits. ",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\lakritschips-small.jpg",
                            ImageUrl = "\\Images\\lakritschips.png",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Lakrits Chips",
                            Price = 20m,
                            SalesPrice = 0m
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
                            CategoryName = "Choklad Godis"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Frukt Godis"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Surt Godis"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Lakrits"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Karameller"
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
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

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
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

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
