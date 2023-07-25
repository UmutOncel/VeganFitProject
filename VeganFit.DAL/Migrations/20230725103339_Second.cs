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
                value: new DateTime(2023, 7, 25, 13, 33, 38, 989, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedBy", "CreatedDate", "Email", "Firstname", "Lastname", "Password", "Role", "State", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2, new DateTime(1999, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 25, 13, 33, 38, 989, DateTimeKind.Local).AddTicks(2655), "pelin@gmail.com", "Pelin", "Uru", "1234", "StandartUser", "Created", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 12, 39, 11, 314, DateTimeKind.Local).AddTicks(9054));
        }
    }
}
