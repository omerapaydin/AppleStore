using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppleStore.Migrations
{
    /// <inheritdoc />
    public partial class TableNew3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99fced23-873b-4f9b-9a87-c3d800a6cc56", "AQAAAAIAAYagAAAAEJmVrMzr5SOMAoGkrYDV825Iw/wXqWPraaBpkbJigVZvZDeZY6xsa//aVcRdUocJpQ==", "6df286e2-faf4-4024-9222-34936a9ad2ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b4337c5-4b31-451a-a1c6-917962197711", "AQAAAAIAAYagAAAAEJX/prAksT5rn9dKPR8gmnY8yiMylUh9xWr1SJlEgH0AzMFvLAKBS//uVlZDBZBj3w==", "19db326a-e600-4bb7-b483-f91c4aff3c8a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
