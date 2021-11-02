using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingAppUsingAsp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDesc", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Chocolate Product" },
                    { 2, null, "Fruit Product" },
                    { 3, null, "Gummy Product" },
                    { 4, null, "Halloween Product" },
                    { 5, null, "Hard Product" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Desc", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Goblet of fire", "\\Images\\thumbnails\\thumbnail1.jpg", "\\Images\\product1.jpg", true, false, "Harry Potter Book", 15.95m },
                    { 2, 2, "Office Desk comes in different color", "\\Images\\thumbnails\\thumbnail2.jpg", "\\Images\\product2.jpg", true, true, "IKEA Office table", 45.95m },
                    { 3, 3, "Mouth watering traditional snacks", "\\Images\\thumbnails\\thumbnail3.jpg", "\\Images\\product3.jpg", true, false, "Indian Snacks Combo", 6.75m },
                    { 4, 4, "Antique Piece for sale. May remind you of your childhood.", "\\Images\\thumbnails\\thumbnail4.jpg", "\\Images\\product4.jpg", true, false, "Nokia 1100", 120.95m },
                    { 5, 5, "Do you want to impress your girlfriend? Go for this cool jacket", "\\Images\\thumbnails\\thumbnail5.jpg", "\\Images\\product5.jpg", true, true, "Denim Jacket", 36.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
