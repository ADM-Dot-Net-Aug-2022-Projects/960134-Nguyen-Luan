using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hoalu.Server.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => new { x.UserId, x.ProductId, x.ProductTypeId });
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visible = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Featured = table.Column<bool>(type: "bit", nullable: false),
                    Visible = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.OrderId, x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Visible = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Deleted", "Name", "Url", "Visible" },
                values: new object[,]
                {
                    { 1, false, "Flowers", "flowers", true },
                    { 2, false, "Plants", "plants", true }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mini" },
                    { 2, "Regular" },
                    { 3, "Large" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Deleted", "Description", "Featured", "ImageUrl", "Title", "Visible" },
                values: new object[,]
                {
                    { 1, 1, false, "Blooming with bright colors to boldly express your every emotion, this exquisite flower bouquet is set to celebrate. Hot pink roses, purple Peruvian lilies, lavender mini carnations, green hypericum berries, lily grass blades and lush greens are brought together to create an incredible flower arrangement. Presented in a clear glass cube vase, this mixed flower bouquet will make that perfect impression on a birthday, anniversary, or as a way to extend your congratulations or thank you wishes.", true, "https://cdn.azflorist.com/wp-content/uploads/20220405121236/C15-4949D.jpg", "Red Rose Bouquet", true },
                    { 2, 1, false, "This sweet bouquet is an expression of your love and affection. Fragrant pink Stargazer lilies are accented with pink statice and arranged in a clear glass vase. Send it for birthday, anniversary, get well, or just because you care.", false, "https://cdn.azflorist.com/wp-content/uploads/20220405122001/S22-4298S.jpg", "Pink Lily Bouquet", true },
                    { 3, 1, false, "Pink Lilies make the eyes dance across the unique design of this flower bouquet, surrounded by the blushing colors of orange roses, lavender cushion poms, hot pink carnations, and lush greens. Presented in a clear glass vase, this fresh flower arrangement has been created just for you to help you send your sweetest thank you, happy anniversary, or thinking of you wishes.", false, "https://cdn.azflorist.com/wp-content/uploads/20220405123118/C5375D.png", "Sunset Bouquet", true },
                    { 4, 1, false, "Our local florists handcraft a stunning display of lilies, roses and other elegant florals to delight them for any and every occasion.", true, "https://cdn.azflorist.com/wp-content/uploads/20220524092019/CHAD.jpeg", "The Pure Clouds", true },
                    { 5, 1, false, "For that superstar in your life, treat them to something so gorgeous, it’s out of this world. Designed by a local florist, the Moonstruck Bouquet comes with a refreshing mix of white florals and arrives in style right to their doorstep.", true, "https://cdn.azflorist.com/wp-content/uploads/20220524101105/PGQP.png", "Moonstruck Bouquet", true },
                    { 6, 1, false, "Stunning sunflowers are mixed with glossy magnolia leaves for a dramatic, day-brightening delivery.", false, "https://image.floranext.com/instances/theflowercart_org/catalog/product/y/o/youregoldenbouquetbyteleflora_1.jpg?w=308&h=308&gen=1", "Sunflower Bouquet", true },
                    { 7, 2, false, "Beautiful dyed Blue Orchid plant, Perfect for someone who loves blue, new baby boy or a special man in your life!", false, "https://fyf.tac-cdn.net/images/products/large/P-149.jpg?auto=webp&quality=60&width=690", "Blue Orchid", true },
                    { 8, 2, false, "Enjoy the southwest with this prickly but beautiful cactus garden.", false, "https://www.treehugger.com/thmb/VpYez07ecRrO4et_DV080D30ErA=/735x0/__opt__aboutcom__coeus__resources__content_migration__mnn__images__2017__09__SucculentsRoundGardenTrayInFrontOfBench-b92233aff63940f8a4ea98981ab98d1d.jpg", "Cactus Garden", true },
                    { 9, 2, false, "The striking Phalaenopsis orchid makes a graceful tribute to loved ones who have passed on. Tastefully set by our florists in a classic glass cube planter, its vibrant green leaves and wing-shaped white blooms are a thoughtful gesture of sympathy when delivered to the home of friends and family.", false, "https://cdn.shopify.com/s/files/1/0150/6262/products/the-sill_white-orchid_bryant_black_variant.jpg?v=1658772624", "White Orchid", true },
                    { 10, 2, false, "Like a best friend, this unique garden of fresh green succulents is adaptable, low-maintenance, and a great addition to any setting.", false, "https://www.bhg.com/thmb/Bsu_svLq5LOM8AvgUgFyDDwb4cg=/1866x1050/smart/filters:no_upscale():focal(1006x509:1008x511)/mini-succulent-container-663ff722-8f8200d7ec4341bea48bc9e4df5d33dc.jpg", "Succelent Garden", true },
                    { 11, 2, false, "The sansevieria or snake plant, features naturalistic river grass and an organic shape. These trendy baskets add style and character to a living room or bedroom. The neutral color and texture fits perfectly in a variety of home settings.\r\nSansevieria is one of the top air purifying plants identified by NASA, removing at least 108 known air pollutants. It is also one of the few plants that releases oxygen during the night.", false, "https://images.costco-static.com/ImageDelivery/imageService?profileId=12026540&imageId=1327184-847__1&recipeName=350", "Sansevieria Snake Plant", true }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "Deleted", "OriginalPrice", "Price", "Visible" },
                values: new object[,]
                {
                    { 1, 1, false, 0m, 19.99m, true },
                    { 1, 2, false, 0m, 29.99m, true },
                    { 1, 3, false, 0m, 39.99m, true },
                    { 2, 1, false, 0m, 19.99m, true },
                    { 2, 2, false, 0m, 29.99m, true },
                    { 2, 3, false, 0m, 39.99m, true },
                    { 3, 2, false, 0m, 49.99m, true },
                    { 3, 3, false, 0m, 69.99m, true },
                    { 4, 2, false, 0m, 49.99m, true },
                    { 4, 3, false, 0m, 69.99m, true },
                    { 5, 1, false, 0m, 25.99m, true },
                    { 5, 2, false, 0m, 35.99m, true },
                    { 6, 1, false, 0m, 45.99m, true },
                    { 6, 2, false, 0m, 55.99m, true },
                    { 7, 2, false, 0m, 35.99m, true },
                    { 8, 1, false, 0m, 15.99m, true },
                    { 9, 2, false, 0m, 35.99m, true },
                    { 10, 1, false, 0m, 15.99m, true },
                    { 11, 3, false, 0m, 45.99m, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductTypeId",
                table: "OrderItems",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
