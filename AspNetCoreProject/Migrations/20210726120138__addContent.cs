using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreProject.Migrations
{
    public partial class _addContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "7b3ae887-b7b9-4da2-95f0-d833cc7f4c95", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b62472e-4f66-49fa-a20f-e7685b9565d8", 0, "7ed3d375-c041-43d1-b5c2-36803fb64930", "den@email.com", true, false, null, "DEN@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEHEV0YRvYkj+OGGrh18YKeCZ459trCarRZHeGFGplWZ6A4wC+V6NMOxHBUMr08On7g==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), "PageIndex", new DateTime(2021, 7, 26, 12, 1, 37, 113, DateTimeKind.Utc).AddTicks(2247), null, null, null, "Текст записи", "Главная", null },
                    { new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), "PageServices", new DateTime(2021, 7, 26, 12, 1, 37, 113, DateTimeKind.Utc).AddTicks(7342), null, null, null, "Текст записи", "Наши услуги", null },
                    { new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), "PageContacts", new DateTime(2021, 7, 26, 12, 1, 37, 113, DateTimeKind.Utc).AddTicks(7419), null, null, null, "Текст записи", "Контакты", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8");
        }
    }
}
