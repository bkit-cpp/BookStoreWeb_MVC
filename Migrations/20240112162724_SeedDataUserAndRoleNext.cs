using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    public partial class SeedDataUserAndRoleNext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "384c2807-bfb0-43b5-86a4-d66561e3f344");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f72b6c13-16c5-4790-a239-18840b1cba36");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "70f6f434-5174-46e2-bfe2-73cee71d23df", "AQAAAAEAACcQAAAAEKAeW6WROhJco/ylJmi7B+OHMCaIfbW86wBgAfikIO8u6cBWYvaLOWbZipPhC3fU6A==", "5521c17c-43c7-4332-b246-671ab8592dba", "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8f532dd-765b-46f0-a332-1a383c67cdac", "AQAAAAEAACcQAAAAEJAnkKsx6WqaeSQiQhUVKsj4j/XgTW+oKCeDoHaPjX88HNZ5cxUgs3OdshjX0NlG6w==", "58fdcab9-2e8f-4ef1-85e9-94eedb93b54c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "957273c2-99b9-48a0-b2f1-ea550d27c29e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "fa467b42-08aa-47f4-bb94-a1d624f89c2f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "042b4000-b6f5-4e63-9cdd-8fec6ac4254a", "AQAAAAEAACcQAAAAEKpBasCFLKkuJ/JOyJRxDtWihOxw28Esc4TsXsLQR+dtwui51mWw0QwIB9oFi+OZMw==", "c1fc3e30-cad0-4d04-b26a-4fa4e43b4488", "admin@123" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05cf8a92-79ef-40a0-88fd-0329993f3c2c", "AQAAAAEAACcQAAAAECwl7Lh3jF8i7eJ9fSxkN3av3zSOQ8B5CDZOhHfe3FUCKunS5VPoddPUd6lub/esDw==", "8789ba14-7d7b-4f50-a292-d50b6b21d1c6" });
        }
    }
}
