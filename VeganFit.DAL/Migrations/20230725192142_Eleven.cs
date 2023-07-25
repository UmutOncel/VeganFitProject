using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeganFit.DAL.Migrations
{
    public partial class Eleven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 21, 41, 772, DateTimeKind.Local).AddTicks(9423), "EF359CE6F0005B1AE73F70F675AA50E8E18BEA9DED1C30957C2769BB99ADF4E9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 22, 21, 41, 772, DateTimeKind.Local).AddTicks(9466));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 7, 25, 21, 45, 27, 137, DateTimeKind.Local).AddTicks(9010), "UUuu1991**" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 21, 45, 27, 137, DateTimeKind.Local).AddTicks(9048));
        }
    }
}
