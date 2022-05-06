using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bootShop.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Telefon" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Bilgisayar" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Tablet" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Discount", "ImageUrl", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 3, 1, null, null, 0.14999999999999999, "https://m.media-amazon.com/images/I/71ZiSXOdnhL._AC_SL1500_.jpg", null, "Iphone", 15000.0 },
                    { 4, 1, null, null, 0.14999999999999999, "https://m.media-amazon.com/images/I/71ZiSXOdnhL._AC_SL1500_.jpg", null, "Iphone", 15000.0 },
                    { 5, 1, null, null, 0.14999999999999999, "https://m.media-amazon.com/images/I/71ZiSXOdnhL._AC_SL1500_.jpg", null, "Iphone", 15000.0 },
                    { 1, 2, null, "16 gb ram", 0.14999999999999999, "https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg", null, "Apple Macbook Air", 20000.0 },
                    { 2, 2, null, "16 gb ram", 0.14999999999999999, "https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg", null, "Apple Macbook Air", 20000.0 }
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
