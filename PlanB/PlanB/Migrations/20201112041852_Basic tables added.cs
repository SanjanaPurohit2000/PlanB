using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanB.Migrations
{
    public partial class Basictablesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 30, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Mobile = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ProductImage1 = table.Column<byte[]>(nullable: false),
                    ProductImage2 = table.Column<byte[]>(nullable: false),
                    ProductImage3 = table.Column<byte[]>(nullable: false),
                    ProductImage4 = table.Column<byte[]>(nullable: true),
                    ProductImage5 = table.Column<byte[]>(nullable: true),
                    ProductImage6 = table.Column<byte[]>(nullable: true),
                    applicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_products_AspNetUsers_applicationUserId",
                        column: x => x.applicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsID = table.Column<int>(nullable: true),
                    applicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_orderDetails_products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orderDetails_AspNetUsers_applicationUserId",
                        column: x => x.applicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wishLists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsID = table.Column<int>(nullable: true),
                    applicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wishLists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_wishLists_products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wishLists_AspNetUsers_applicationUserId",
                        column: x => x.applicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_ProductsID",
                table: "orderDetails",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_applicationUserId",
                table: "orderDetails",
                column: "applicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_products_applicationUserId",
                table: "products",
                column: "applicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_wishLists_ProductsID",
                table: "wishLists",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_wishLists_applicationUserId",
                table: "wishLists",
                column: "applicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderDetails");

            migrationBuilder.DropTable(
                name: "wishLists");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
