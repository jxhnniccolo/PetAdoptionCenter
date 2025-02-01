using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionCenter.Migrations
{
    /// <inheritdoc />
    public partial class StaffData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationDate", "ApprovalDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5529), new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5533), new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5534), new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a788ebb6-1d73-4b42-9751-9a707f81a82d", "AQAAAAIAAYagAAAAEGk3Xj4KLfx1eRGZXGPliTtWJc/Ic/kLDX77j5xP2SLjU9oufaksF7FP3n4Oxwqx2g==", "cbf20891-db73-4b28-83cb-94be8b2eaa73" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5311), new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5326), new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5466), new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5469), new DateTime(2025, 2, 2, 2, 20, 11, 387, DateTimeKind.Local).AddTicks(5469) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationDate", "ApprovalDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9801), new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9803), new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9804), new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ab4c30b-64ff-4664-91c1-f0e32d740ace", "AQAAAAIAAYagAAAAEE36NWFhr2HdgxHxMMPIBMjwG1PnzU6Z5ndMTP+DEzCibMY6frckI4bIbm1J3ubKBA==", "914ad0b2-a46a-48dd-a072-6f6702b3e93c" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9561), new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9574), new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9738), new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9740), new DateTime(2025, 2, 2, 2, 4, 37, 653, DateTimeKind.Local).AddTicks(9741) });
        }
    }
}
