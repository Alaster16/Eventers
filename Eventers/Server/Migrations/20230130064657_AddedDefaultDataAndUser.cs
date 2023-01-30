using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eventers.Server.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 46, 57, 0, DateTimeKind.Local).AddTicks(7233), new DateTime(2023, 1, 30, 14, 46, 57, 0, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 46, 57, 0, DateTimeKind.Local).AddTicks(8172), new DateTime(2023, 1, 30, 14, 46, 57, 0, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 46, 56, 998, DateTimeKind.Local).AddTicks(7031), new DateTime(2023, 1, 30, 14, 46, 56, 999, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 46, 56, 999, DateTimeKind.Local).AddTicks(7580), new DateTime(2023, 1, 30, 14, 46, 56, 999, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 46, 57, 1, DateTimeKind.Local).AddTicks(507), new DateTime(2023, 1, 30, 14, 46, 57, 1, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 46, 57, 1, DateTimeKind.Local).AddTicks(1515), new DateTime(2023, 1, 30, 14, 46, 57, 1, DateTimeKind.Local).AddTicks(1519) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 39, 55, 719, DateTimeKind.Local).AddTicks(7090), new DateTime(2023, 1, 30, 14, 39, 55, 719, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 39, 55, 719, DateTimeKind.Local).AddTicks(8190), new DateTime(2023, 1, 30, 14, 39, 55, 719, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 39, 55, 717, DateTimeKind.Local).AddTicks(7005), new DateTime(2023, 1, 30, 14, 39, 55, 718, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 39, 55, 718, DateTimeKind.Local).AddTicks(7448), new DateTime(2023, 1, 30, 14, 39, 55, 718, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 39, 55, 720, DateTimeKind.Local).AddTicks(584), new DateTime(2023, 1, 30, 14, 39, 55, 720, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 39, 55, 720, DateTimeKind.Local).AddTicks(1324), new DateTime(2023, 1, 30, 14, 39, 55, 720, DateTimeKind.Local).AddTicks(1327) });
        }
    }
}
