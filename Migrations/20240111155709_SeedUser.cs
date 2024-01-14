using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    public partial class SeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4e3589b0-772f-4f0f-b1ab-9557f26f6e13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e8e62750-aaf7-48a4-a10e-5eba4b123fac");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Opccupation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "d990dfb9-dfc6-405c-827b-b6a97eb470f2", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AdminWeb", "AQAAAAEAACcQAAAAELizXUK+b2RTkf4CSH+/0cB9ykksaJCZP79mJq5DDh1GOhnJZ8wVCI9HW9CDvypZrA==", null, false, "60599586-c695-4524-9aad-722f3ccaf935", false, "admin@example.com" },
                    { "2", 0, "f3cc1b4c-c4d4-43a5-9d2d-afeee6c39593", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "BacSi", "AQAAAAEAACcQAAAAENlCn1GZkAvq/gD5CJ+rtWTKJUH7XJr3uYc/s5cJOELvlE0r0GURPF/cCLcoYpukrg==", null, false, "d1017a70-69b4-413f-82ed-8c3c2c1cacdb", false, "user@example.com" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "6ff993b5-5538-4ee0-ad0c-513c3c30d756");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2fee62e1-bd53-4ef0-9c1b-39ebd8b80fbc");
        }
    }
}
