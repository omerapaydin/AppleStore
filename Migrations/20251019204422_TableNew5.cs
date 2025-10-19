using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppleStore.Migrations
{
    /// <inheritdoc />
    public partial class TableNew5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    FavoriteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PublishedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.FavoriteId);
                    table.ForeignKey(
                        name: "FK_Favorites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteItems",
                columns: table => new
                {
                    FavoriteItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    FavoriteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteItems", x => x.FavoriteItemId);
                    table.ForeignKey(
                        name: "FK_FavoriteItems_Favorites_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "Favorites",
                        principalColumn: "FavoriteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteItems_Products_ProductId",
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
                values: new object[] { "65e64d3a-50e6-4d86-bd6b-2f98f46bc5ab", "AQAAAAIAAYagAAAAEA9bdgKkohnqDPx3/1Vrgho+6a6lpP4L4XM/djqOpHqXwawEzZjfo/N4uCUrm5C46Q==", "6347b9c8-53da-4a5d-bcfb-6e7f57dcd077" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf61a125-4836-4009-8d39-c15720a2e90c", "AQAAAAIAAYagAAAAELSWts4OJRvfeobzb+V0Bsxh+9y7ijBw+/NoAAXaXfkPhLxRSPhm+t7Tw55TubS8DQ==", "452dac2a-5e98-4fb7-a4c6-9a802ce9f1b5" });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteItems_FavoriteId",
                table: "FavoriteItems",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteItems_ProductId",
                table: "FavoriteItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteItems");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "107706a5-bbfb-4ea0-8ff4-cb20f7f4b9ec", "AQAAAAIAAYagAAAAEPoKZJmxXW0axlqGjgnPjVDuofU6FU/LLYjOH1Xrt2fDosJh++dfzQrZ54WvmZtqNg==", "2f60bd77-063d-49bc-b869-7835cc9c6151" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94a6dd88-fd75-4faf-957a-e1a90a5f204f", "AQAAAAIAAYagAAAAEEE9b6f/WOKgBaalitis4TuCuAVrt6V3D+Z01Vt9xtlwjeIU74axUbj2EcT8rm2IIA==", "cb9d5b1b-e92b-4eb0-a074-562d5f3026aa" });
        }
    }
}
