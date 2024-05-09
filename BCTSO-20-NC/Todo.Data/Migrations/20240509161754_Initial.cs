using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Todo.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "EndDate", "Priority", "StartDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "პირველი საქმის აღწერა...", new DateTime(2024, 5, 9, 21, 17, 53, 807, DateTimeKind.Local).AddTicks(2654), 2, new DateTime(2024, 5, 9, 20, 17, 53, 807, DateTimeKind.Local).AddTicks(2653), 1, "პირველი საქმე" },
                    { 2, "მეორე საქმის აღწერა...", new DateTime(2024, 5, 9, 21, 17, 53, 807, DateTimeKind.Local).AddTicks(2660), 1, new DateTime(2024, 5, 9, 20, 17, 53, 807, DateTimeKind.Local).AddTicks(2659), 1, "მეორე საქმე" },
                    { 3, "მესამე საქმის აღწერა...", new DateTime(2024, 5, 10, 1, 17, 53, 807, DateTimeKind.Local).AddTicks(2662), 4, new DateTime(2024, 5, 9, 20, 17, 53, 807, DateTimeKind.Local).AddTicks(2661), 2, "მესამე საქმე" },
                    { 4, "მეოთხე საქმის აღწერა...", new DateTime(2024, 5, 16, 20, 17, 53, 807, DateTimeKind.Local).AddTicks(2664), 1, new DateTime(2024, 5, 9, 20, 17, 53, 807, DateTimeKind.Local).AddTicks(2663), 1, "მეოთხე საქმე" },
                    { 5, "მეხუთე საქმის აღწერა...", new DateTime(2024, 5, 12, 20, 17, 53, 807, DateTimeKind.Local).AddTicks(2668), 3, new DateTime(2024, 5, 9, 20, 17, 53, 807, DateTimeKind.Local).AddTicks(2667), 1, "მეხუთე საქმე" },
                    { 6, "მეექვსე საქმის აღწერა...", new DateTime(2024, 5, 19, 20, 17, 53, 807, DateTimeKind.Local).AddTicks(2670), 2, new DateTime(2024, 5, 9, 20, 17, 53, 807, DateTimeKind.Local).AddTicks(2669), 2, "მეექვსე საქმე" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
