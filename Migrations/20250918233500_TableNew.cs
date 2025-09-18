using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppleStore.Migrations
{
    /// <inheritdoc />
    public partial class TableNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e8b69e3-42b2-4214-8e08-b85af94ab7bd", "AQAAAAIAAYagAAAAEPyigf/zy0GXM6irpuRPtN3uoTyi+UwmNr9yDIDye6XnZj5Oh3aQSaKPQcKBRiIskQ==", "5613dedf-6602-4b91-adeb-cacf36439518" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e430235-1fde-40e9-95bb-d56bcffe1319", "AQAAAAIAAYagAAAAEELc16PSgTVGUlfzDPxp/cQGyhSvIeqGJ17DPhOsCev1QljLtfRZufrdq9lNCQiOaQ==", "3abb53c2-2bfa-4fc0-b144-96cb52d6844b" });
        }
    }
}
