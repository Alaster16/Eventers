using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eventers.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyAdress", "CompanyEmail", "CompanyID", "CompanyName", "CompanyNumber", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Changi Prison", "Superayam@gmail.com", 867375, "Superman123", 93572345, "System", new DateTime(2023, 1, 27, 5, 49, 6, 233, DateTimeKind.Local).AddTicks(4331), new DateTime(2023, 1, 27, 5, 49, 6, 233, DateTimeKind.Local).AddTicks(4342), "System" },
                    { 2, "Dairy Farm", "Superpork@gmail.com", 565866, "Batman123", 93657364, "System", new DateTime(2023, 1, 27, 5, 49, 6, 233, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 1, 27, 5, 49, 6, 233, DateTimeKind.Local).AddTicks(6105), "System" }
                });

            migrationBuilder.InsertData(
                table: "Eventees",
                columns: new[] { "Id", "Address", "ContactNumber", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "Email", "EventeeID", "Gender", "NRIC", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Jurong East", 86118499, "System", new DateTime(2023, 1, 27, 5, 49, 6, 230, DateTimeKind.Local).AddTicks(7645), 2002, new DateTime(2023, 1, 27, 5, 49, 6, 232, DateTimeKind.Local).AddTicks(598), "njx2002@gmail.com", 112233, "Male", 53, "Alaster", "System" },
                    { 2, "Jurong West", 96731728, "System", new DateTime(2023, 1, 27, 5, 49, 6, 232, DateTimeKind.Local).AddTicks(2625), 1865, new DateTime(2023, 1, 27, 5, 49, 6, 232, DateTimeKind.Local).AddTicks(2635), "jeffng@gmail.com", 334455, "Female", 193, "Jeff", "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "StaffEmail", "StaffID", "StaffName", "StaffNumber", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 27, 5, 49, 6, 233, DateTimeKind.Local).AddTicks(9067), new DateTime(2023, 1, 27, 5, 49, 6, 233, DateTimeKind.Local).AddTicks(9073), "Gingerbreast@gmail.com", 357683, "Gingerbread", 86843757, "System" },
                    { 2, "System", new DateTime(2023, 1, 27, 5, 49, 6, 233, DateTimeKind.Local).AddTicks(9848), new DateTime(2023, 1, 27, 5, 49, 6, 233, DateTimeKind.Local).AddTicks(9852), "Gingerball@gmail.com", 657485, "Gingerballs", 93768486, "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Eventees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
