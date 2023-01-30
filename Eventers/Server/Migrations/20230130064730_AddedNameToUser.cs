using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eventers.Server.Migrations
{
    public partial class AddedNameToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 47, 29, 702, DateTimeKind.Local).AddTicks(3149), new DateTime(2023, 1, 30, 14, 47, 29, 702, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 47, 29, 702, DateTimeKind.Local).AddTicks(4101), new DateTime(2023, 1, 30, 14, 47, 29, 702, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 47, 29, 700, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 1, 30, 14, 47, 29, 701, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 47, 29, 701, DateTimeKind.Local).AddTicks(3638), new DateTime(2023, 1, 30, 14, 47, 29, 701, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 47, 29, 702, DateTimeKind.Local).AddTicks(6451), new DateTime(2023, 1, 30, 14, 47, 29, 702, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 14, 47, 29, 702, DateTimeKind.Local).AddTicks(7249), new DateTime(2023, 1, 30, 14, 47, 29, 702, DateTimeKind.Local).AddTicks(7253) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
