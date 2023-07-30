using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeganFit.DAL.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 29, 14, 34, 17, 33, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 29, 14, 34, 17, 33, DateTimeKind.Local).AddTicks(3113));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 29, 14, 31, 46, 802, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 29, 14, 31, 46, 802, DateTimeKind.Local).AddTicks(6333));
        }
    }
}
