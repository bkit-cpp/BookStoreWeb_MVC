using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    public partial class SeedDataAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9dea84cd-8eb8-49cb-bf6a-e7eb8ffcb356");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "0403fa63-3b7a-4827-8259-8c9559533d64");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9165bc63-b80b-433c-bfe3-563f7fb0d674", "AQAAAAEAACcQAAAAEEpf4FZs5yxXgk6Nm7rD5AU+B1BNhmNjm3ngsmfQ/M2nANVaw6SGdTJdjQJSOhBtnw==", "bd7c12bc-a172-4b3c-bab9-962c5d857512" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dac75ad0-5a28-420c-b3fd-db2625ee58fa", "AQAAAAEAACcQAAAAEF7ZO0K2d2z15ThItIMk/0wtrCJ7sRhsDCoYxxkpuwxNFGhDLGK0KvGIq7RHkboftQ==", "02a11bee-e159-445f-bf3b-d5566addb701" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DatePublished", "Description", "IBNS", "ImageUrl", "Language", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Astrid Lindgren", new DateTime(2013, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "9789129688313", "/themes/images/tab-item1.jpg", "Swedish", 139, "Bröderna Lejonhjärta" },
                    { 2, "Dennis Lehane", new DateTime(2011, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "9780062068408", "/themes/images/tab-item2.jpg", "English", 91, "Mystic River" },
                    { 3, "Ernest Hemingway", new DateTime(1994, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "9780062068408", "/themes/images/tab-item3.jpg", "English", 84, "The Old Man and the Sea" },
                    { 4, "Cormac McCarthy", new DateTime(2007, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "9780307386458", "/themes/images/tab-item7.jpg", "English", 95, "The Road" },
                    { 5, "John Steinbeck", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "9780062068408", "/themes/images/tab-item5.jpg", "English", 166, "Of Mice and Men" },
                    { 6, "J. R. R. Tolkien", new DateTime(1991, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "9780261102354", "/themes/images/tab-item6.jpg", "English", 100, "The Fellowship of the Ring" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d9c942fc-a5e4-49e4-bb22-b2f03655f5f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "67547c9b-a96d-4a56-b165-95a9ac380198");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a28512d9-7766-4473-8890-b0c9cff3bad9", "AQAAAAEAACcQAAAAEP/29JMkFG7o+hVvSRAE3x2KmXtxCadJcDzZLELI6sYUwB8kWg4+K4nwTOFhbgZXXQ==", "08ad2192-14e2-4e9a-a1fe-7d1ef730c411" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b33dd88d-9e1b-4ec1-8624-8a464247b228", "AQAAAAEAACcQAAAAECqVBTfe3TAi5MM8JxBKC8lN1PKx6M70Ih1drW9p67W2HT6z+HBmJvCt/XeLYevSkA==", "16b738be-8bf7-4ff4-8ceb-0cd1c7c91f99" });
        }
    }
}
