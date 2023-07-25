using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeganFit.DAL.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Datas_OptionalProducts_OptionalProductId",
                table: "Datas");

            migrationBuilder.DropForeignKey(
                name: "FK_Datas_Products_ProductId",
                table: "Datas");

            migrationBuilder.DropForeignKey(
                name: "FK_Datas_Users_UserId",
                table: "Datas");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Datas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Datas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OptionalProductId",
                table: "Datas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 11, 48, 46, 575, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.AddForeignKey(
                name: "FK_Datas_OptionalProducts_OptionalProductId",
                table: "Datas",
                column: "OptionalProductId",
                principalTable: "OptionalProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Datas_Products_ProductId",
                table: "Datas",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Datas_Users_UserId",
                table: "Datas",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Datas_OptionalProducts_OptionalProductId",
                table: "Datas");

            migrationBuilder.DropForeignKey(
                name: "FK_Datas_Products_ProductId",
                table: "Datas");

            migrationBuilder.DropForeignKey(
                name: "FK_Datas_Users_UserId",
                table: "Datas");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Datas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Datas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OptionalProductId",
                table: "Datas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 11, 42, 38, 411, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.AddForeignKey(
                name: "FK_Datas_OptionalProducts_OptionalProductId",
                table: "Datas",
                column: "OptionalProductId",
                principalTable: "OptionalProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Datas_Products_ProductId",
                table: "Datas",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Datas_Users_UserId",
                table: "Datas",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
