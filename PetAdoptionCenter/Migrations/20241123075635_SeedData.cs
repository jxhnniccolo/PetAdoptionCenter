using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetAdoptionCenter.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1088), new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1104), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1106), new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1107), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1290), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1292), new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1292), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1371), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1372), new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1373), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1374), new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1374), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1376), new DateTime(2024, 11, 23, 15, 56, 34, 550, DateTimeKind.Local).AddTicks(1376), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
