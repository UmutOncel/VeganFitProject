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
                value: new DateTime(2023, 7, 25, 17, 12, 50, 127, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 17, 12, 50, 127, DateTimeKind.Local).AddTicks(6824));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 54, 47, 993, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 54, 47, 993, DateTimeKind.Local).AddTicks(3871));
        }
    }
}
