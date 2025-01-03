using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetAdoptionCenter.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "1b344420-abdd-4cf1-a9dc-d34ac06c9b63", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKKp28L8WZejbymrMojDvlr+v8Ti2YWbg3kgsMzq8L/Qt/z/o6wU0lwyKBsjThpMRA==", null, false, "6f2b53ab-73a4-426b-9495-f1c6c8833a53", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8514), new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8524), new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8705), new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8707), new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8796), new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8798), new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8800), new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8802), new DateTime(2024, 11, 23, 16, 23, 55, 138, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6147), new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6157), new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6341), new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6422), new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6424), new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6427), new DateTime(2024, 11, 23, 16, 10, 7, 406, DateTimeKind.Local).AddTicks(6428) });
        }
    }
}
