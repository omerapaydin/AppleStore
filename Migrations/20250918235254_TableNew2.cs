using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppleStore.Migrations
{
    /// <inheritdoc />
    public partial class TableNew2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    AddressLine = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    PostId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31c8796f-0a29-4a9f-99af-4d854ab44b1a", "AQAAAAIAAYagAAAAEGxD77fHIAZF2DXG8ehz99tBIEePE7+jwZPCB4eaBLSxtnYiRps1PZcbVTxSOAKwjA==", "cf9340ec-b638-436c-aa0c-97de7d5a777c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "504a9033-0ef6-4880-9802-ac8293cff8a3", "AQAAAAIAAYagAAAAED4blqiebXMKCnNlrSOZcD+xyjyN5WfA84MSUx/SRgjcApud+s1qoR2WEkz7ebCFMg==", "30b042c6-d3e2-4395-baa7-a4f3af18c30c" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0df9231-aa00-4caa-9dac-40c585abfd9d", "AQAAAAIAAYagAAAAEMdqN0H+uvahqLdMBt8e8zUVZKnuy/YRqArtsyAvLDSK/Zbwba29fN82GcBbMcBneA==", "2203ee08-a4ed-4d13-9a89-67afd1e1e30c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3e420e3-dda5-4d78-9618-a1495b697640", "AQAAAAIAAYagAAAAEB1d6Z/B14JesL4s5l96l1BtiB7lbPMf9dFuvlwg+O47a7OmJbXh89oINOhVk2/3QQ==", "164cba1d-49c1-4595-a729-d06b5710411a" });
        }
    }
}
