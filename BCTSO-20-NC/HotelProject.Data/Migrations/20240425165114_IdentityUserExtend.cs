﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentityUserExtend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa2bc577-957b-48e0-bc85-c1d6e9156c4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b60a5743-ddb9-44b0-8d2f-ace71c59eba3");

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
                    { "13b0a725-5f60-422b-a532-55de826983dc", null, "Administrator", "ADMINISTRATOR" },
                    { "d60e893f-ddf4-492e-96e5-fe9f8d95acff", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 25, 20, 51, 13, 644, DateTimeKind.Local).AddTicks(970), new DateTime(2024, 5, 5, 20, 51, 13, 644, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 25, 20, 51, 13, 644, DateTimeKind.Local).AddTicks(984), new DateTime(2024, 5, 25, 20, 51, 13, 644, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 25, 20, 51, 13, 644, DateTimeKind.Local).AddTicks(999), new DateTime(2024, 5, 15, 20, 51, 13, 644, DateTimeKind.Local).AddTicks(1000) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13b0a725-5f60-422b-a532-55de826983dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d60e893f-ddf4-492e-96e5-fe9f8d95acff");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aa2bc577-957b-48e0-bc85-c1d6e9156c4e", null, "Administrator", "ADMINISTRATOR" },
                    { "b60a5743-ddb9-44b0-8d2f-ace71c59eba3", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 25, 20, 46, 4, 80, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 5, 5, 20, 46, 4, 80, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 25, 20, 46, 4, 80, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 5, 25, 20, 46, 4, 80, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 25, 20, 46, 4, 80, DateTimeKind.Local).AddTicks(6793), new DateTime(2024, 5, 15, 20, 46, 4, 80, DateTimeKind.Local).AddTicks(6793) });
        }
    }
}
