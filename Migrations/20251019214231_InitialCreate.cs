using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppleStore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7df7e3a4-edb1-46e1-8ea4-cab8fe032456", "AQAAAAIAAYagAAAAECgDJKgaW187QeIctozdPNlrx+3IKTFTWRiBhSPFJvIH7IFq5p+RK/AVGcGxqXizWg==", "8774d38d-9bec-46ff-b44a-c7ac9c3c097f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d60e295d-f42e-4474-a75b-13697b293e58", "AQAAAAIAAYagAAAAEDHYZN5metFtPlzunUBEzaJmnvf/AYVVb+DbiBBkr36H9j+g8/2F67ZUmnVTU0xbnQ==", "aaac3fdf-15a8-4f3f-8e33-54ecc4534b46" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7602f40b-fc4a-4172-a68c-917545a84287", "AQAAAAIAAYagAAAAEAkBE4+6BmUrFxUsW7gBr62B6fLyD+hf3b1ai6ogYRDwTmv79HPgW9HdTh+queU/yQ==", "2d3b3b3a-25fb-4376-b6c5-224ced66a337" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3a8c9e7-6d88-49c6-a2dd-a469a7148628", "AQAAAAIAAYagAAAAEOLDe28j8YreOSZ+pGgmqYilEhS7o8GfL6FFD++YDVggDGiIL5YqPns4zVjreflNug==", "15687614-2578-4de8-ab34-63daa43b2e0f" });
        }
    }
}
