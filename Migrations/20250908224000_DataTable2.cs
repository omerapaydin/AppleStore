using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppleStore.Migrations
{
    /// <inheritdoc />
    public partial class DataTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "ImageFile", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "98de0061-c09c-41a8-9ecc-f6ffee89ba4f", "info@gmail.com", true, "Ömer Apaydın", "p1.jpg", false, null, null, null, "AQAAAAIAAYagAAAAEEkpjc/SBi4oupxuIh+9zQ8jluHsz2P2z/Wu1RRNHyrhnX3526dygsnuaJ/d9GRQ9w==", null, false, "85dbd55c-5f8c-4c10-88a1-14d1c0209e5c", false, "omerapaydin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Telefonlar" },
                    { 2, "Bilgisayarlar" },
                    { 3, "Aksesuarlar" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Image", "IsActive", "Price", "PublishedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Apple HomePod Hoparlör", "homepod.jpg", true, 45000m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", "1" },
                    { 2, 1, "Apple Şarj Kablosu Magsafe", "magsafe.jpg", true, 55000m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", "1" },
                    { 3, 1, "Apple AirPods Pro 2", "airpods-pro-2-hero-select-202409.png", true, 75000m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", "2" },
                    { 4, 2, "Apple AirPods Pro 2", "airpods-max.jpeg", true, 75000m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", "2" },
                    { 5, 2, "Apple Key Pro 2", "key.jpeg", true, 75000m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", "2" },
                    { 6, 3, "Apple Mouse Pro ", "mouse.jpeg", true, 75000m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
