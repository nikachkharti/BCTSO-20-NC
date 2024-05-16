using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.Data.Migrations
{
    /// <inheritdoc />
    public partial class TodoUsersConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Todos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bc44ccc-b13d-4766-a7da-e137692dd4eb", "AQAAAAIAAYagAAAAEOwk+oe3suhWNEk01neU3KGefI3hk+T2i6CP1X59l72y01o+kM2xHycU7mMu2yewqw==", "06d91d6d-2f15-4a75-a489-bc1df623abfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9c479e8-a609-419a-a990-fc276c6efab0", "AQAAAAIAAYagAAAAEJ6Y0ZnJGyDB18HR8pyUFejsHVCCTeGDaykPqIP9r63G8lElw2j+lDa1pxiWL5NP4w==", "f8f68dd9-f76b-43ac-bc69-f24af4035d03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a045a883-598f-4ba1-be4f-ac7f310cbb04", "AQAAAAIAAYagAAAAEIlPQgzVtj1LIuqaJyHp4DmexQrtdwe2EojYYdeAOx9e6zU0qIXgXwQ68aBG4maXAA==", "f4666ea8-a0ce-4927-a9d9-d72286d9ae2e" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 16, 21, 20, 0, 323, DateTimeKind.Local).AddTicks(1648), new DateTime(2024, 5, 16, 20, 20, 0, 323, DateTimeKind.Local).AddTicks(1648), "D514EDC9-94BB-416F-AF9D-7C13669689C9" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 16, 21, 20, 0, 323, DateTimeKind.Local).AddTicks(1654), new DateTime(2024, 5, 16, 20, 20, 0, 323, DateTimeKind.Local).AddTicks(1653), "D514EDC9-94BB-416F-AF9D-7C13669689C9" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 17, 1, 20, 0, 323, DateTimeKind.Local).AddTicks(1656), new DateTime(2024, 5, 16, 20, 20, 0, 323, DateTimeKind.Local).AddTicks(1656), "D514EDC9-94BB-416F-AF9D-7C13669689C9" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 23, 20, 20, 0, 323, DateTimeKind.Local).AddTicks(1659), new DateTime(2024, 5, 16, 20, 20, 0, 323, DateTimeKind.Local).AddTicks(1658), "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 19, 20, 20, 0, 323, DateTimeKind.Local).AddTicks(1662), new DateTime(2024, 5, 16, 20, 20, 0, 323, DateTimeKind.Local).AddTicks(1662), "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 26, 20, 20, 0, 323, DateTimeKind.Local).AddTicks(1666), new DateTime(2024, 5, 16, 20, 20, 0, 323, DateTimeKind.Local).AddTicks(1665), "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserId",
                table: "Todos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_AspNetUsers_UserId",
                table: "Todos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_AspNetUsers_UserId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1327a85d-2a3a-4aed-808e-a002e0878f92", "AQAAAAIAAYagAAAAELi/6wGml22UHrtYVVk+a/nN9J1Kyb3lF3KSvXgsZOueTffBt+Bdlidee9576Z0jng==", "ea80d66c-ff9e-4935-8c25-b7d08cb5be40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b535cb5f-e894-4c60-b982-21cd0e4c3f7d", "AQAAAAIAAYagAAAAEJDVTiAn221DXm0v4tVb/OQrYcJsjM2nDaqf2vYkpBkwe/mfNRITV1/ZONmMa9CCKA==", "40e665fc-aa69-4932-8adb-c6e508a69742" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af3ea34d-f2b0-44a8-b595-544dfde980bd", "AQAAAAIAAYagAAAAEKX7Cnk/YFeElMohCjZtstGjtqnzlFtaapccXitWacJkXPTLHajsWb8WuNfRooaflA==", "49ae04d9-758f-411d-aeab-239d283cbfdc" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 47, 45, 56, DateTimeKind.Local).AddTicks(6415), new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 47, 45, 56, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 2, 47, 45, 56, DateTimeKind.Local).AddTicks(6424), new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6426), new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6429), new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6432), new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6431) });
        }
    }
}
