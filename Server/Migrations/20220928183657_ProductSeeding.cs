using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hoalu.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Dozen of Red Roses", "https://res.cloudinary.com/bloomnation/image/upload/c_pad,d_vendor:global:catalog:product:image.png,f_auto,fl_preserve_transparency,q_auto/v1643762539/vendor/7294/catalog/product/4/c/4c829ffbc556ca0e1fee0faaebe6d8d6_31.jpg", "Red Roses", 12.99m },
                    { 2, "One Orchid plant with Vase", "https://www.almanac.com/sites/default/files/styles/large/public/image_nodes/orchid-pot-shutterstock_491195248.jpg?itok=k9XxFA4z", "Orchids", 49.99m },
                    { 3, "Amaze your guests with beautiful centerpieces on your table", "https://i.pinimg.com/564x/3d/a1/e0/3da1e049cc8b83efe88da727d547d00d--easy-cheap-wedding-ideas-simple-floral-wedding.jpg", "Wedding Centerpiece", 49.99m },
                    { 4, "Show your love ones they matter with this beautiful flower arrangement combo. 3 pieces set", "https://www.instagram.com/p/ChkilUGJxNn/", "Valentine Combo Arrange", 99.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
