using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candyshop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base (options)
        {

        }
        
        public DbSet<Candy> Candies { get; set; }
        public DbSet<Category> Categores { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Choklad Godis" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Frukt Godis" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Surt Godis" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Lakrits" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Karameller" });

            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 1,
                Name = "Lindt Choklad Praliner",
                Price = 4.95M,
                Description = " Choklad fyllda praliner",
                CategoryId = 1,
                ImageUrl = "\\Images\\Lindt-choklad-praliner.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Lindt-choklad-praliner-small.jpg",
                IsInStock = true,
                IsOnSale=false

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 2,
                Name = "Geisha Choklad",
                Price = 3.95M,
                Description = " Chokladgodisarnas drottning och lösviktsgodisets tungviktare. Geisha är älskad av generationer och kommer så att vara under en lång tid framöver. Den mjuka chokladen och den nötiga karaktären gifter sig i munnen och tillfredsställer ditt chokladbegär likt ingenting annat.",
                CategoryId = 1,
                ImageUrl = "\\Images\\geisha.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\geisha-small.jpg",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 3,
                Name = "Romerska Bågar",
                Price = 2.95M,
                Description = " Halvmånar med smak av apelsinchoklad",
                CategoryId = 1,
                ImageUrl = "\\Images\\romerskabagar.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\romerskabagar-small.jpg",
                IsInStock = true,
                IsOnSale = true

            });
           
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId =4,
                Name = "Persikor",
                Price = 6.95M,
                Description = " Persikor är ju inte bara en fantastiskt god frukt, det är också en magisk godis. Det är mångas favorit som alltid slinker ner i lördagspåsen och förgyller både dagar, kvällar och nätter. En trogen vapendragare helt enkelt!",
                CategoryId = 2,
                ImageUrl = "\\Images\\persiker.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\persiker-small.jpg",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 5,
                Name = "Vattenmelon",
                Price = 3.95M,
                Description = " I en perfekt mix av sött och surt så är dessa vattenmeloner ett måste i livsnjutarens godisskål! De är redan en klassiker bland lösviktsgodiset, och nu kan du njuta ännu mer av dem med en hel påse av godiset.",
                CategoryId = 2,
                ImageUrl = "\\Images\\vattenemelon.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\vattenmelon-small.jpg",
                IsInStock = true,
                IsOnSale = false

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 6,
                Name = "Geléhallon",
                Price = 4.95M,
                Description = " När det kommer till klassisk konfektyr så blir det knappast bättre än det supersmarriga geléhallonet! Se till att ladda upp med en påse eller två innan helgen stundar.",
                CategoryId = 2,
                ImageUrl = "\\Images\\gelehallon.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\gelehallon-small.jpg",
                IsInStock = false,
                IsOnSale = true

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 7,
                Name = "Suratungor",
                Price = 4.95M,
                Description = " Sura godistungor med smak av frukt. Perfekt till lördagsgodiset eller kalaset!",
                CategoryId = 3,
                ImageUrl = "\\Images\\surtunga.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\surtunga-small.jpg",
                IsInStock = true,
                IsOnSale = false

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 8,
                Name = "Sur Vattenmelon",
                Price = 6.95M,
                Description = " Minidynamit Sur Vattenmelon från Karamello. Sursockrat godis med smak av vattenmelon.",
                CategoryId = 3,
                ImageUrl = "\\Images\\survattenmelon.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\survattenmelon-small.jpg",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 9,
                Name = "Fizzypop",
                Price = 4.95M,
                Description = " En minivariant av de populära Fizzypop-flaskorna.Mjuk konsistens och god bubbelgumsmak.",
                CategoryId = 3,
                ImageUrl = "\\Images\\fizzypop.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\fizzypop-small.jpg",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 10,
                Name = "Ultra Violet",
                Price = 3.95M,
                Description = " Tack och hej, ditt gamla violsnask. Här är Ultra Violet! Saltlakrits med vit choklad, viol och salmiak.",
                CategoryId = 4,
                ImageUrl = "\\Images\\Ultra-Violet.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Ultra-Violet-small.jpg",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 11,
                Name = "Svenskjävlar",
                Price = 5.95M,
                Description = " Världens. Saltaste. Lakrits. Vågar du? Lakrits- och salmiakkräm omgiven av salmiaklakrits och salmiak.",
                CategoryId = 4,
                ImageUrl = "\\Images\\svenskjavlar.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\svenskjavlar-small.jpg",
                IsInStock = false,
                IsOnSale = true

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 12,
                Name = "Lakrisal",
                Price = 6.95M,
                Description = " Salmiak pastilles with a strong taste of salmiak.",
                CategoryId = 4,
                ImageUrl = "\\Images\\lakrisal.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\lakrisal-small.jpg",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 13,
                Name = "Polkagrisar",
                Price = 3.95M,
                Description = " Njut av klassikern i karamellform, tillverkad i vår anrika karamellfabrik i Hudiksvall",
                CategoryId = 5,
                ImageUrl = "\\Images\\polka.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\polka-small.jpg",
                IsInStock = true,
                IsOnSale = false

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 14,
                Name = "Tomteklubbor",
                Price = 2.95M,
                Description = " Äntligen finns våra populära tomteklubbor med fruktsmak! De finns i fem olika färger och säljes osorterat (det blir alltså en överraskning vilken du får).",
                CategoryId = 5,
                ImageUrl = "\\Images\\tomteklubbor.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\tomteklubbor-small.jpg",
                IsInStock = false,
                IsOnSale = true

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 15,
                Name = "Kameleonter",
                Price = 5.95M,
                Description = " Kanske såg du dessa godingar i kiosken när du var liten och köpte ditt lördagsgodis? En gammal favorit med en fantastisk smak av salmiak, anis och lakrits. Karamellen har ett brunt lager av salt på utsidan, oförklarligt god med ett surt pulver inne i mitten!",
                CategoryId = 5,
                ImageUrl = "\\Images\\kamaleonter.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\kameleonter-small.jpg",
                IsInStock = true,
                IsOnSale = false

            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 16,
                Name = "Lakrits Chips",
                Price = 20M,
                Description = " Lakritschips på riktigt!  VARNING! Det är svårt att sluta stoppa dessa chips i munnen när smaklökarna vant sig efter krocken av salta chips och söt lakrits. ",
                CategoryId = 4,
                ImageUrl = "\\Images\\lakritschips.png",
                ImageThumbnailUrl = "\\Images\\thumbnails\\lakritschips-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });


        }

    }
}
