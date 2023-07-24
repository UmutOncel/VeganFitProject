using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeganFit.DAL.Migrations
{
    public partial class Thirt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 16, 34, 52, 405, DateTimeKind.Local).AddTicks(2926));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 15, 40, 21, 495, DateTimeKind.Local).AddTicks(3903));
        }
    }
}
