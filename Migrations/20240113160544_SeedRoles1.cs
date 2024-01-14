using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    public partial class SeedRoles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4a2537f3-7c2b-409a-a94b-37d783032252");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7d31cc76-5203-43c7-9b12-77a5fac273ca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Opccupation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "70f6f434-5174-46e2-bfe2-73cee71d23df", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AdminWeb", "AQAAAAEAACcQAAAAEKAeW6WROhJco/ylJmi7B+OHMCaIfbW86wBgAfikIO8u6cBWYvaLOWbZipPhC3fU6A==", null, false, "5521c17c-43c7-4332-b246-671ab8592dba", false, "admin@example.com" },
                    { "2", 0, "a8f532dd-765b-46f0-a332-1a383c67cdac", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "BacSi", "AQAAAAEAACcQAAAAEJAnkKsx6WqaeSQiQhUVKsj4j/XgTW+oKCeDoHaPjX88HNZ5cxUgs3OdshjX0NlG6w==", null, false, "58fdcab9-2e8f-4ef1-85e9-94eedb93b54c", false, "user@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "2" });
        }
    }
}
