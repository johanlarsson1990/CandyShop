using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Candyshop.Migrations
{
    public partial class Firstcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categores",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescriptin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categores", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candies",
                columns: table => new
                {
                    CandyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsOnSale = table.Column<bool>(nullable: false),
                    IsInStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candies", x => x.CandyId);
                    table.ForeignKey(
                        name: "FK_Candies_Categores_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categores",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    CandyId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Candies_CandyId",
                        column: x => x.CandyId,
                        principalTable: "Candies",
                        principalColumn: "CandyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    CandyId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Candies_CandyId",
                        column: x => x.CandyId,
                        principalTable: "Candies",
                        principalColumn: "CandyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categores",
                columns: new[] { "CategoryId", "CategoryDescriptin", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Choklad Godis" },
                    { 2, null, "Frukt Godis" },
                    { 3, null, "Surt Godis" },
                    { 4, null, "Lakrits" },
                    { 5, null, "Karameller" }
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, " Choklad fyllda praliner", "\\Images\\thumbnails\\Lindt-choklad-praliner-small.jpg", "\\Images\\Lindt-choklad-praliner.jpg", true, false, "Lindt Choklad Praliner", 4.95m },
                    { 2, 1, " Chokladgodisarnas drottning och lösviktsgodisets tungviktare. Geisha är älskad av generationer och kommer så att vara under en lång tid framöver. Den mjuka chokladen och den nötiga karaktären gifter sig i munnen och tillfredsställer ditt chokladbegär likt ingenting annat.", "\\Images\\thumbnails\\geisha-small.jpg", "\\Images\\geisha.jpg", true, true, "Geisha Choklad", 3.95m },
                    { 3, 1, " Halvmånar med smak av apelsinchoklad", "\\Images\\thumbnails\\romerskabagar-small.jpg", "\\Images\\romerskabagar.jpg", true, true, "Romerska Bågar", 2.95m },
                    { 4, 2, " Persikor är ju inte bara en fantastiskt god frukt, det är också en magisk godis. Det är mångas favorit som alltid slinker ner i lördagspåsen och förgyller både dagar, kvällar och nätter. En trogen vapendragare helt enkelt!", "\\Images\\thumbnails\\persiker-small.jpg", "\\Images\\persiker.jpg", true, true, "Persikor", 6.95m },
                    { 5, 2, " I en perfekt mix av sött och surt så är dessa vattenmeloner ett måste i livsnjutarens godisskål! De är redan en klassiker bland lösviktsgodiset, och nu kan du njuta ännu mer av dem med en hel påse av godiset.", "\\Images\\thumbnails\\vattenmelon-small.jpg", "\\Images\\vattenemelon.jpg", true, false, "Vattenmelon", 3.95m },
                    { 6, 2, " När det kommer till klassisk konfektyr så blir det knappast bättre än det supersmarriga geléhallonet! Se till att ladda upp med en påse eller två innan helgen stundar.", "\\Images\\thumbnails\\gelehallon-small.jpg", "\\Images\\gelehallon.jpg", false, true, "Geléhallon", 4.95m },
                    { 7, 3, " Sura godistungor med smak av frukt. Perfekt till lördagsgodiset eller kalaset!", "\\Images\\thumbnails\\surtunga-small.jpg", "\\Images\\surtunga.jpg", true, false, "Suratungor", 4.95m },
                    { 8, 3, " Minidynamit Sur Vattenmelon från Karamello. Sursockrat godis med smak av vattenmelon.", "\\Images\\thumbnails\\survattenmelon-small.jpg", "\\Images\\survattenmelon.jpg", true, true, "Sur Vattenmelon", 6.95m },
                    { 9, 3, " En minivariant av de populära Fizzypop-flaskorna.Mjuk konsistens och god bubbelgumsmak.", "\\Images\\thumbnails\\fizzypop-small.jpg", "\\Images\\fizzypop.jpg", true, true, "Fizzypop", 4.95m },
                    { 10, 4, " Tack och hej, ditt gamla violsnask. Här är Ultra Violet! Saltlakrits med vit choklad, viol och salmiak.", "\\Images\\thumbnails\\Ultra-Violet-small.jpg", "\\Images\\Ultra-Violet.jpg", true, true, "Ultra Violet", 3.95m },
                    { 11, 4, " Världens. Saltaste. Lakrits. Vågar du? Lakrits- och salmiakkräm omgiven av salmiaklakrits och salmiak.", "\\Images\\thumbnails\\svenskjavlar-small.jpg", "\\Images\\svenskjavlar.jpg", false, true, "Svenskjävlar", 5.95m },
                    { 12, 4, " Salmiak pastilles with a strong taste of salmiak.", "\\Images\\thumbnails\\lakrisal-small.jpg", "\\Images\\lakrisal.jpg", true, true, "Lakrisal", 6.95m },
                    { 16, 4, " Lakritschips på riktigt!  VARNING! Det är svårt att sluta stoppa dessa chips i munnen när smaklökarna vant sig efter krocken av salta chips och söt lakrits. ", "\\Images\\thumbnails\\lakritschips-small.jpg", "\\Images\\lakritschips.png", true, true, "Lakrits Chips", 20m },
                    { 13, 5, " Njut av klassikern i karamellform, tillverkad i vår anrika karamellfabrik i Hudiksvall", "\\Images\\thumbnails\\polka-small.jpg", "\\Images\\polka.jpg", true, false, "Polkagrisar", 3.95m },
                    { 14, 5, " Äntligen finns våra populära tomteklubbor med fruktsmak! De finns i fem olika färger och säljes osorterat (det blir alltså en överraskning vilken du får).", "\\Images\\thumbnails\\tomteklubbor-small.jpg", "\\Images\\tomteklubbor.jpg", false, true, "Tomteklubbor", 2.95m },
                    { 15, 5, " Kanske såg du dessa godingar i kiosken när du var liten och köpte ditt lördagsgodis? En gammal favorit med en fantastisk smak av salmiak, anis och lakrits. Karamellen har ett brunt lager av salt på utsidan, oförklarligt god med ett surt pulver inne i mitten!", "\\Images\\thumbnails\\kameleonter-small.jpg", "\\Images\\kamaleonter.jpg", true, false, "Kameleonter", 5.95m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Candies_CategoryId",
                table: "Candies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CandyId",
                table: "OrderDetails",
                column: "CandyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CandyId",
                table: "ShoppingCartItems",
                column: "CandyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Candies");

            migrationBuilder.DropTable(
                name: "Categores");
        }
    }
}
