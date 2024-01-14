using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    public partial class EditRoleAndUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d990dfb9-dfc6-405c-827b-b6a97eb470f2", "AQAAAAEAACcQAAAAELizXUK+b2RTkf4CSH+/0cB9ykksaJCZP79mJq5DDh1GOhnJZ8wVCI9HW9CDvypZrA==", "60599586-c695-4524-9aad-722f3ccaf935", "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3cc1b4c-c4d4-43a5-9d2d-afeee6c39593", "AQAAAAEAACcQAAAAENlCn1GZkAvq/gD5CJ+rtWTKJUH7XJr3uYc/s5cJOELvlE0r0GURPF/cCLcoYpukrg==", "d1017a70-69b4-413f-82ed-8c3c2c1cacdb" });
        }
    }
}
