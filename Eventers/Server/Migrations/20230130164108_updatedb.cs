using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eventers.Server.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 41, 8, 169, DateTimeKind.Local).AddTicks(2842), new DateTime(2023, 1, 31, 0, 41, 8, 169, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 41, 8, 169, DateTimeKind.Local).AddTicks(3784), new DateTime(2023, 1, 31, 0, 41, 8, 169, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 41, 8, 166, DateTimeKind.Local).AddTicks(9411), new DateTime(2023, 1, 31, 0, 41, 8, 167, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 41, 8, 168, DateTimeKind.Local).AddTicks(1304), new DateTime(2023, 1, 31, 0, 41, 8, 168, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 41, 8, 169, DateTimeKind.Local).AddTicks(6445), new DateTime(2023, 1, 31, 0, 41, 8, 169, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 41, 8, 169, DateTimeKind.Local).AddTicks(7139), new DateTime(2023, 1, 31, 0, 41, 8, 169, DateTimeKind.Local).AddTicks(7143) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 28, 38, 291, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 1, 31, 0, 28, 38, 291, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 28, 38, 291, DateTimeKind.Local).AddTicks(7464), new DateTime(2023, 1, 31, 0, 28, 38, 291, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 28, 38, 289, DateTimeKind.Local).AddTicks(1799), new DateTime(2023, 1, 31, 0, 28, 38, 290, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 28, 38, 290, DateTimeKind.Local).AddTicks(4474), new DateTime(2023, 1, 31, 0, 28, 38, 290, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 28, 38, 292, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 1, 31, 0, 28, 38, 292, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 28, 38, 292, DateTimeKind.Local).AddTicks(1005), new DateTime(2023, 1, 31, 0, 28, 38, 292, DateTimeKind.Local).AddTicks(1009) });
        }
    }
}
