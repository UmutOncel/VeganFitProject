using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeganFit.DAL.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Calori = table.Column<double>(type: "float", nullable: false),
                    Serving = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Picture = table.Column<byte[]>(type: "Image", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Datas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calori = table.Column<double>(type: "float", nullable: false),
                    Datetime = table.Column<DateTime>(type: "date", nullable: false),
                    Meal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Datas_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Datas_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserWeight = table.Column<double>(type: "float", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "date", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weights_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Datas",
                columns: new[] { "Id", "Calori", "CreatedBy", "CreatedDate", "Datetime", "Meal", "ProductId", "ProductName", "State", "UpdatedBy", "UpdatedDate", "UserEmail", "UserId" },
                values: new object[,]
                {
                    { 1, 100.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Kepekli Ekmek", "Created", null, null, "pelin@gmail.com", null },
                    { 2, 116.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5129), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Elma", "Created", null, null, "pelin@gmail.com", null },
                    { 3, 220.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5147), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Ceviz", "Created", null, null, "pelin@gmail.com", null },
                    { 4, 50.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Kayısı", "Created", null, null, "pelin@gmail.com", null },
                    { 5, 174.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Badem", "Created", null, null, "pelin@gmail.com", null },
                    { 6, 80.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5195), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Çilek", "Created", null, null, "pelin@gmail.com", null },
                    { 7, 250.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Karpuz", "Created", null, null, "pelin@gmail.com", null },
                    { 8, 350.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5226), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Bulgur Pilavı", "Created", null, null, "pelin@gmail.com", null },
                    { 9, 150.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5241), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Müsli", "Created", null, null, "pelin@gmail.com", null },
                    { 10, 330.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5256), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Nar", "Created", null, null, "pelin@gmail.com", null },
                    { 11, 300.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5272), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Vegan Sade Peynir", "Created", null, null, "pelin@gmail.com", null },
                    { 12, 230.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5286), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Portakal", "Created", null, null, "pelin@gmail.com", null },
                    { 13, 190.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5301), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Turşu", "Created", null, null, "pelin@gmail.com", null },
                    { 14, 120.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Domates Çorbası", "Created", null, null, "pelin@gmail.com", null },
                    { 15, 150.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5331), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Patates Salatası", "Created", null, null, "pelin@gmail.com", null },
                    { 16, 390.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5355), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Yulaf Ezmesi", "Created", null, null, "pelin@gmail.com", null },
                    { 17, 340.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5371), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Vegan Sade Peynir", "Created", null, null, "pelin@gmail.com", null },
                    { 18, 50.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5387), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Yeşil Çay", "Created", null, null, "pelin@gmail.com", null },
                    { 19, 169.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5403), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Turşu", "Created", null, null, "pelin@gmail.com", null },
                    { 20, 320.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Mücver", "Created", null, null, "pelin@gmail.com", null },
                    { 21, 190.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Armut", "Created", null, null, "pelin@gmail.com", null },
                    { 22, 90.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5451), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Kuru Üzüm", "Created", null, null, "pelin@gmail.com", null },
                    { 23, 146.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5468), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Muzlu Vegan Fransız Tostu", "Created", null, null, "pelin@gmail.com", null },
                    { 24, 50.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5484), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Yeşil Çay", "Created", null, null, "pelin@gmail.com", null },
                    { 25, 120.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5499), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Çok Tahıllı Ekmek", "Created", null, null, "pelin@gmail.com", null },
                    { 26, 329.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Zeytinyağlı Taze Fasulye", "Created", null, null, "pelin@gmail.com", null },
                    { 27, 240.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5532), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Ratatouille", "Created", null, null, "pelin@gmail.com", null },
                    { 28, 90.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5548), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Mandalina", "Created", null, null, "pelin@gmail.com", null },
                    { 29, 180.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Müsli", "Created", null, null, "pelin@gmail.com", null },
                    { 30, 190.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5581), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Karışık Sebze", "Created", null, null, "pelin@gmail.com", null },
                    { 31, 150.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Portakal Suyu", "Created", null, null, "pelin@gmail.com", null },
                    { 32, 245.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5637), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Zeytinyağlı Taze Fasulye", "Created", null, null, "pelin@gmail.com", null },
                    { 33, 266.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5653), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Fırında Domatesli Kabak Dilimleri", "Created", null, null, "pelin@gmail.com", null },
                    { 34, 222.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5668), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Siyah Zeytin", "Created", null, null, "pelin@gmail.com", null },
                    { 35, 328.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5684), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Badem Sütü", "Created", null, null, "pelin@gmail.com", null },
                    { 36, 230.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5699), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Karışık Sebze", "Created", null, null, "pelin@gmail.com", null },
                    { 37, 253.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Mantar ve Pırasalı Tofu", "Created", null, null, "pelin@gmail.com", null },
                    { 38, 200.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5731), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Domates Çorbası", "Created", null, null, "pelin@gmail.com", null },
                    { 39, 336.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5746), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Yaban Mersinli Kinoa Lapası", "Created", null, null, "pelin@gmail.com", null },
                    { 40, 242.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Siyah Zeytin", "Created", null, null, "pelin@gmail.com", null },
                    { 41, 138.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5775), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Badem Sütü", "Created", null, null, "pelin@gmail.com", null },
                    { 42, 110.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Maydonoz", "Created", null, null, "pelin@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Datas",
                columns: new[] { "Id", "Calori", "CreatedBy", "CreatedDate", "Datetime", "Meal", "ProductId", "ProductName", "State", "UpdatedBy", "UpdatedDate", "UserEmail", "UserId" },
                values: new object[,]
                {
                    { 43, 267.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5803), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Ispanaklı Pizza", "Created", null, null, "pelin@gmail.com", null },
                    { 44, 221.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Domates Çorbası", "Created", null, null, "pelin@gmail.com", null },
                    { 45, 336.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Şeftali Püreli Tatlı Kuskus", "Created", null, null, "pelin@gmail.com", null },
                    { 46, 123.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Yeşil Biber", "Created", null, null, "pelin@gmail.com", null },
                    { 47, 140.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5870), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Portakal Suyu", "Created", null, null, "pelin@gmail.com", null },
                    { 48, 169.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5884), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Patates Salatası", "Created", null, null, "pelin@gmail.com", null },
                    { 49, 320.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5898), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Burger", "Created", null, null, "pelin@gmail.com", null },
                    { 50, 200.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5913), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Domates Çorbası", "Created", null, null, "pelin@gmail.com", null },
                    { 51, 170.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Sebzeli Makarna", "Created", null, null, "pelin@gmail.com", null },
                    { 52, 120.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5942), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Kepekli Ekmek", "Created", null, null, "pelin@gmail.com", null },
                    { 53, 345.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5957), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Vegan Sade Peynir", "Created", null, null, "pelin@gmail.com", null },
                    { 54, 140.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Elma", "Created", null, null, "pelin@gmail.com", null },
                    { 55, 227.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(5985), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Bulgur Pilavı", "Created", null, null, "pelin@gmail.com", null },
                    { 56, 230.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6000), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Karpuz", "Created", null, null, "pelin@gmail.com", null },
                    { 57, 330.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Ispanaklı Börek", "Created", null, null, "pelin@gmail.com", null },
                    { 58, 120.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Kuru Üzüm", "Created", null, null, "pelin@gmail.com", null },
                    { 59, 80.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Yeşil Çay", "Created", null, null, "pelin@gmail.com", null },
                    { 60, 150.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6059), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Elma", "Created", null, null, "pelin@gmail.com", null },
                    { 61, 330.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6073), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Avokado Soslu Patetes", "Created", null, null, "pelin@gmail.com", null },
                    { 62, 400.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6088), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Şeftali Püreli Tatlı Kuskus", "Created", null, null, "pelin@gmail.com", null },
                    { 63, 300.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6102), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Mantarlı Kinoa Risotto", "Created", null, null, "pelin@gmail.com", null },
                    { 64, 80.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6197), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Kepekli Ekmek", "Created", null, null, "aynur@gmail.com", null },
                    { 65, 120.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Elma", "Created", null, null, "aynur@gmail.com", null },
                    { 66, 200.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Ceviz", "Created", null, null, "aynur@gmail.com", null },
                    { 67, 60.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6243), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Kayısı", "Created", null, null, "aynur@gmail.com", null },
                    { 68, 180.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Badem", "Created", null, null, "aynur@gmail.com", null },
                    { 69, 100.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Çilek", "Created", null, null, "aynur@gmail.com", null },
                    { 70, 220.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6288), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Karpuz", "Created", null, null, "aynur@gmail.com", null },
                    { 71, 360.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Bulgur Pilavı", "Created", null, null, "aynur@gmail.com", null },
                    { 72, 180.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6317), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Müsli", "Created", null, null, "aynur@gmail.com", null },
                    { 73, 300.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6331), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Nar", "Created", null, null, "aynur@gmail.com", null },
                    { 74, 320.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6346), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Vegan Sade Peynir", "Created", null, null, "aynur@gmail.com", null },
                    { 75, 200.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6362), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Portakal", "Created", null, null, "aynur@gmail.com", null },
                    { 76, 200.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6376), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Turşu", "Created", null, null, "aynur@gmail.com", null },
                    { 77, 130.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6390), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Domates Çorbası", "Created", null, null, "aynur@gmail.com", null },
                    { 78, 160.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6405), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Patates Salatası", "Created", null, null, "aynur@gmail.com", null },
                    { 79, 400.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6419), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Yulaf Ezmesi", "Created", null, null, "aynur@gmail.com", null },
                    { 80, 350.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6433), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Vegan Sade Peynir", "Created", null, null, "aynur@gmail.com", null },
                    { 81, 60.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6447), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Yeşil Çay", "Created", null, null, "aynur@gmail.com", null },
                    { 82, 180.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6462), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Turşu", "Created", null, null, "aynur@gmail.com", null },
                    { 83, 360.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6477), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Mücver", "Created", null, null, "aynur@gmail.com", null },
                    { 84, 200.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6491), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Armut", "Created", null, null, "aynur@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Datas",
                columns: new[] { "Id", "Calori", "CreatedBy", "CreatedDate", "Datetime", "Meal", "ProductId", "ProductName", "State", "UpdatedBy", "UpdatedDate", "UserEmail", "UserId" },
                values: new object[,]
                {
                    { 85, 100.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6506), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Kuru Üzüm", "Created", null, null, "aynur@gmail.com", null },
                    { 86, 180.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6520), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Muzlu Vegan Fransız Tostu", "Created", null, null, "aynur@gmail.com", null },
                    { 87, 80.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6534), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Yeşil Çay", "Created", null, null, "aynur@gmail.com", null },
                    { 88, 125.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6549), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Çok Tahıllı Ekmek", "Created", null, null, "aynur@gmail.com", null },
                    { 89, 350.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6563), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Zeytinyağlı Taze Fasulye", "Created", null, null, "aynur@gmail.com", null },
                    { 90, 250.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6579), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Ratatouille", "Created", null, null, "aynur@gmail.com", null },
                    { 91, 100.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6593), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Mandalina", "Created", null, null, "aynur@gmail.com", null },
                    { 92, 190.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6608), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Müsli", "Created", null, null, "aynur@gmail.com", null },
                    { 93, 200.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6623), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Karışık Sebze", "Created", null, null, "aynur@gmail.com", null },
                    { 94, 160.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6637), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Portakal Suyu", "Created", null, null, "aynur@gmail.com", null },
                    { 95, 250.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6652), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Zeytinyağlı Taze Fasulye", "Created", null, null, "aynur@gmail.com", null },
                    { 96, 250.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6666), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Fırında Domatesli Kabak Dilimleri", "Created", null, null, "aynur@gmail.com", null },
                    { 97, 200.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6681), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Siyah Zeytin", "Created", null, null, "aynur@gmail.com", null },
                    { 98, 300.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6697), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Badem Sütü", "Created", null, null, "aynur@gmail.com", null },
                    { 99, 200.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Karışık Sebze", "Created", null, null, "aynur@gmail.com", null },
                    { 100, 240.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6726), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Mantar ve Pırasalı Tofu", "Created", null, null, "aynur@gmail.com", null },
                    { 101, 180.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Domates Çorbası", "Created", null, null, "aynur@gmail.com", null },
                    { 102, 290.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6755), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Yaban Mersinli Kinoa Lapası", "Created", null, null, "aynur@gmail.com", null },
                    { 103, 230.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Siyah Zeytin", "Created", null, null, "aynur@gmail.com", null },
                    { 104, 150.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6784), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Badem Sütü", "Created", null, null, "aynur@gmail.com", null },
                    { 105, 150.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Maydonoz", "Created", null, null, "aynur@gmail.com", null },
                    { 106, 300.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Ispanaklı Pizza", "Created", null, null, "aynur@gmail.com", null },
                    { 107, 250.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6829), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Domates Çorbası", "Created", null, null, "aynur@gmail.com", null },
                    { 108, 300.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Şeftali Püreli Tatlı Kuskus", "Created", null, null, "aynur@gmail.com", null },
                    { 109, 150.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6883), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Yeşil Biber", "Created", null, null, "aynur@gmail.com", null },
                    { 110, 231.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6898), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Portakal Suyu", "Created", null, null, "aynur@gmail.com", null },
                    { 111, 264.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6913), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Patates Salatası", "Created", null, null, "aynur@gmail.com", null },
                    { 112, 250.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6928), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Burger", "Created", null, null, "aynur@gmail.com", null },
                    { 113, 160.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6943), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Domates Çorbası", "Created", null, null, "aynur@gmail.com", null },
                    { 114, 200.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6957), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Sebzeli Makarna", "Created", null, null, "aynur@gmail.com", null },
                    { 115, 100.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6972), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Kepekli Ekmek", "Created", null, null, "aynur@gmail.com", null },
                    { 116, 400.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(6986), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Vegan Sade Peynir", "Created", null, null, "aynur@gmail.com", null },
                    { 117, 146.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(7002), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Elma", "Created", null, null, "aynur@gmail.com", null },
                    { 118, 342.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(7016), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Bulgur Pilavı", "Created", null, null, "aynur@gmail.com", null },
                    { 119, 344.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(7031), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Karpuz", "Created", null, null, "aynur@gmail.com", null },
                    { 120, 342.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(7046), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Ispanaklı Börek", "Created", null, null, "aynur@gmail.com", null },
                    { 121, 123.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(7061), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Kuru Üzüm", "Created", null, null, "aynur@gmail.com", null },
                    { 122, 80.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(7076), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabah", null, "Yeşil Çay", "Created", null, null, "aynur@gmail.com", null },
                    { 123, 120.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(7090), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Elma", "Created", null, null, "aynur@gmail.com", null },
                    { 124, 221.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(7105), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öğle", null, "Avokado Soslu Patetes", "Created", null, null, "aynur@gmail.com", null },
                    { 125, 344.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(7119), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Şeftali Püreli Tatlı Kuskus", "Created", null, null, "aynur@gmail.com", null },
                    { 126, 255.0, null, new DateTime(2023, 7, 31, 19, 59, 18, 67, DateTimeKind.Local).AddTicks(7135), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akşam", null, "Mantarlı Kinoa Risotto", "Created", null, null, "aynur@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Message", "State", "UpdatedBy", "UpdatedDate", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 7, 31, 19, 59, 18, 68, DateTimeKind.Local).AddTicks(5669), "Uygulama için çok teşekkür ederim. Her şeyi ile tam istediğim gibi sade basit ve anlaşılır bir uygulamadır. Elinize sağlık", "Created", null, null, null, "Aynur" },
                    { 2, null, new DateTime(2023, 7, 31, 19, 59, 18, 68, DateTimeKind.Local).AddTicks(5719), "Uygulama için teşekkürler. Başarılarınızın devamını dileriz.", "Created", null, null, null, "Pelin" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Calori", "CreatedBy", "CreatedDate", "Picture", "ProductName", "Serving", "State", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 128.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kepekli Ekmek", "46", "Created", null, null },
                    { 2, 116.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elma", "223", "Created", null, null },
                    { 3, 193.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ceviz", "30", "Created", null, null },
                    { 4, 105.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Muz", "223", "Created", null, null },
                    { 5, 1.5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maydonoz", "0.5", "Created", null, null },
                    { 6, 16.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Siyah Zeytin", "15.2", "Created", null, null },
                    { 7, 32.799999999999997, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yeşil Biber", "164", "Created", null, null },
                    { 8, 16.800000000000001, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kayısı", "35", "Created", null, null },
                    { 9, 75.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mercimek Çorbası", "100", "Created", null, null },
                    { 10, 174.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Badem", "30", "Created", null, null },
                    { 11, 39.299999999999997, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Badem Sütü", "262", "Created", null, null },
                    { 12, 8.5999999999999996, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Çilek", "27", "Created", null, null },
                    { 13, 86.5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Portakal", "184", "Created", null, null },
                    { 14, 22.100000000000001, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Domates", "123", "Created", null, null },
                    { 15, 96.400000000000006, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Müsli", "28.2", "Created", null, null },
                    { 16, 234.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nar", "282", "Created", null, null },
                    { 17, 116.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kepekli Grissini", "100", "Created", null, null },
                    { 18, 30.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vegan Sade Peynir", "87.3", "Created", null, null },
                    { 20, 116.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bulgur Pilavı", "89.2", "Created", null, null },
                    { 21, 119.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Zeytin Yağı", "13.5", "Created", null, null },
                    { 22, 116.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Konserve Yeşil Bezelye", "163", "Created", null, null },
                    { 23, 85.799999999999997, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Karpuz", "286", "Created", null, null },
                    { 24, 15.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mandalina", "23.8", "Created", null, null },
                    { 25, 74.799999999999997, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ispanaklı Börek", "28.4", "Created", null, null },
                    { 26, 4.2000000000000002, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Turşu", "35", "Created", null, null },
                    { 27, 79.400000000000006, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Domates Çorbası", "248", "Created", null, null },
                    { 28, 358.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Patates Salatası", "250", "Created", null, null },
                    { 29, 166.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yulaf Ezmesi", "234", "Created", null, null },
                    { 30, 79.900000000000006, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Karışık Sebze", "163", "Created", null, null },
                    { 31, 41.899999999999999, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kuru Üzüm", "14", "Created", null, null },
                    { 32, 68.900000000000006, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Çok Tahıllı Ekmek", "26", "Created", null, null },
                    { 33, 125.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sebzeli Makarna", "100", "Created", null, null },
                    { 34, 38.700000000000003, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Portakal Suyu", "86", "Created", null, null },
                    { 35, 2.5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yeşil Çay", "245", "Created", null, null },
                    { 36, 16.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Zeytinyağlı Taze Fasulye", "20.3", "Created", null, null },
                    { 37, 52.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ezogelin Çorbası", "100", "Created", null, null },
                    { 38, 86.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mücver", "74.8", "Created", null, null },
                    { 39, 101.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Armut", "178", "Created", null, null },
                    { 40, 106.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Burger", "100", "Created", null, null },
                    { 41, 26.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ratatouille", "100", "Created", null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Calori", "CreatedBy", "CreatedDate", "Picture", "ProductName", "Serving", "State", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 42, 129.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ispanaklı Pizza", "100", "Created", null, null },
                    { 43, 110.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mantarlı Kinoa Risotto", "100", "Created", null, null },
                    { 44, 45.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fırında Domatesli Kabak Dilimleri", "100", "Created", null, null },
                    { 45, 164.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Muzlu Vegan Fransız Tostu", "100", "Created", null, null },
                    { 46, 80.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Avokado Soslu Patetes", "100", "Created", null, null },
                    { 47, 92.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mantar ve Pırasalı Tofu", "100", "Created", null, null },
                    { 48, 47.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Patates ve Roka Çorbası", "100", "Created", null, null },
                    { 49, 140.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Şeftali Püreli Tatlı Kuskus", "100", "Created", null, null },
                    { 50, 68.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yaban Mersinli Kinoa Lapası", "100", "Created", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedBy", "CreatedDate", "Email", "Firstname", "Lastname", "Password", "Role", "State", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1991, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 31, 19, 59, 18, 65, DateTimeKind.Local).AddTicks(2775), "admin@gmail.com", "Umut", "Öncel", "EF359CE6F0005B1AE73F70F675AA50E8E18BEA9DED1C30957C2769BB99ADF4E9", "Admin", "Created", null, null },
                    { 2, new DateTime(1967, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 31, 19, 59, 18, 65, DateTimeKind.Local).AddTicks(2866), "pelin@gmail.com", "Pelin", "Uru", "B8667A10663F6E4222C5BC68D4E3CB22B51C7812CFB45EE687B60E3F850FC896", "StandartUser", "Created", null, null },
                    { 3, new DateTime(1960, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 31, 19, 59, 18, 65, DateTimeKind.Local).AddTicks(2904), "aynur@gmail.com", "Aynur", "Aydın", "B7E5671FA183586670E8CF95B06AB3A574B94867B3670F433C8B43EE41714AEA", "StandartUser", "Created", null, null }
                });

            migrationBuilder.InsertData(
                table: "Weights",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "RecordDate", "State", "UpdatedBy", "UpdatedDate", "UserId", "UserName", "UserWeight" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 67.0 },
                    { 2, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 67.0 },
                    { 3, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8027), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 67.0 },
                    { 4, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 67.0 },
                    { 5, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 66.0 },
                    { 6, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8073), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 66.0 },
                    { 7, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8088), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 66.0 },
                    { 8, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 65.0 },
                    { 9, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8118), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 65.0 },
                    { 10, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8132), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 65.0 },
                    { 11, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8147), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Pelin", 64.5 },
                    { 12, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8213), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 58.0 },
                    { 13, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8229), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 58.0 },
                    { 14, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8244), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 58.0 },
                    { 15, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8259), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 58.0 },
                    { 16, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8273), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 58.0 },
                    { 17, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8288), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 57.5 },
                    { 18, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8303), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 57.5 },
                    { 19, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8317), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 56.0 },
                    { 20, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8332), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 56.0 },
                    { 21, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8348), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 55.0 },
                    { 22, null, new DateTime(2023, 7, 31, 19, 59, 18, 69, DateTimeKind.Local).AddTicks(8363), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", null, null, null, "Aynur", 54.5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Datas_ProductId",
                table: "Datas",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Datas_UserId",
                table: "Datas",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductName",
                table: "Products",
                column: "ProductName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weights_UserId",
                table: "Weights",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datas");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Weights");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
