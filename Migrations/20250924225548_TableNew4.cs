using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppleStore.Migrations
{
    /// <inheritdoc />
    public partial class TableNew4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
