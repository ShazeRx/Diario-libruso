using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diario_libruso.Data.Migrations
{
    public partial class PrzemiotyListyPrzedmiotow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListaPrzedmiotowId",
                table: "Klasy",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ListyPrzedmiotow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListyPrzedmiotow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Przedmioty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    Opis = table.Column<string>(type: "TEXT", nullable: true),
                    IdNauczyciela = table.Column<string>(type: "TEXT", nullable: true),
                    ListaPrzedmiotowId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przedmioty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Przedmioty_AspNetUsers_IdNauczyciela",
                        column: x => x.IdNauczyciela,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Przedmioty_ListyPrzedmiotow_ListaPrzedmiotowId",
                        column: x => x.ListaPrzedmiotowId,
                        principalTable: "ListyPrzedmiotow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b98939f3-4964-44dd-9e84-73a82fe9e7bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "b36997c3-4a61-4a39-be59-52d9f20289c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "3ff2d8ae-9512-4fd9-888b-a66fd6059f1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "f9f7dd7d-1195-4d55-8e2f-10903f475f01");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc3bedbe-5cc1-4289-a7e2-abf1f135ec0c", "AQAAAAEAACcQAAAAEFkCDfqGHoWN/Q4VsLddUzrZ60bzxeUtAivy33APTyW8uIiGES8ooMBTei3NIaPdPQ==", "dabd0b0c-6ef3-48e4-a37f-1de6f6318d1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2ab10c9-0f04-4565-b526-19dca2838757", "AQAAAAEAACcQAAAAEAKlhfx//t8sV66jO6wPxeQcPyK9L0LhTY24TQVILb0YdSbEJcNkmKK1rrWxPPyl/g==", "7ee6b580-6622-4da2-b08b-8eafb07f4456" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8e52b059-d2e9-40e5-bf4e-6a9605cbc355", "AQAAAAEAACcQAAAAEPzjGjAo/Ns5GmpfNj9dQIa55azy88lhDU+aAvv76AbNZitPJO1t+X22QK96iTSkeA==", "eebac68b-57e0-4434-af71-684cb859b8a5", "nauczyciel@email.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d85831b-fc7a-423a-9eee-9581f0d37c8f", "AQAAAAEAACcQAAAAECU/6FKksi604coXnCu8ZJsmsWGB5HEojLDRKjNkisoGJlBkL6LWYRe4KGJpUvhl3Q==", "a262184f-ef3a-4e3c-97a4-dc6e6719809d" });

            migrationBuilder.UpdateData(
                table: "Klasy",
                keyColumn: "Id",
                keyValue: 2,
                column: "Znak",
                value: "");

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2021, 12, 1, 9, 51, 52, 42, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataDodania",
                value: new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Klasy_ListaPrzedmiotowId",
                table: "Klasy",
                column: "ListaPrzedmiotowId");

            migrationBuilder.CreateIndex(
                name: "IX_Przedmioty_IdNauczyciela",
                table: "Przedmioty",
                column: "IdNauczyciela");

            migrationBuilder.CreateIndex(
                name: "IX_Przedmioty_ListaPrzedmiotowId",
                table: "Przedmioty",
                column: "ListaPrzedmiotowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Klasy_ListyPrzedmiotow_ListaPrzedmiotowId",
                table: "Klasy",
                column: "ListaPrzedmiotowId",
                principalTable: "ListyPrzedmiotow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Klasy_ListyPrzedmiotow_ListaPrzedmiotowId",
                table: "Klasy");

            migrationBuilder.DropTable(
                name: "Przedmioty");

            migrationBuilder.DropTable(
                name: "ListyPrzedmiotow");

            migrationBuilder.DropIndex(
                name: "IX_Klasy_ListaPrzedmiotowId",
                table: "Klasy");

            migrationBuilder.DropColumn(
                name: "ListaPrzedmiotowId",
                table: "Klasy");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "891fc6db-d034-4a2c-84c1-ff81c16144ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "2c63b998-8c21-48df-9419-233d12ed6959");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "09bbd94f-aa9f-4f0d-94af-63cf88bae513");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "978073e2-e2af-4da6-9717-e70e10471af6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df010c8c-e4d6-4bb4-ab0b-a6bba6ad6944", "AQAAAAEAACcQAAAAEBcV+D0KQPaLWAm8cfC9RYe2iJCc55ycb/yWwI4wc5iBzTngR0deOGp9lIO5nN1jzQ==", "238beb60-0b60-4642-a208-22639121b8ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f392f69-e543-4808-9486-3d177833c3a2", "AQAAAAEAACcQAAAAENetbKdMqlTtkJWNb3Ojj5NrVaDE3k4Bj0dMG7E3cm/E1ma9EQjA1e0asiC3A0RfWg==", "d3883eef-56f5-4b65-9264-9e09e805f54c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "63da66ef-8ef5-4544-bb21-a7855a78ccaf", "AQAAAAEAACcQAAAAEKhZeYAt6wiyw+v9FciK4DXv77owaDEgdgRgFMld3ida/U3i2rB36RCYaR+BkamipQ==", "8159d7fa-b0df-40dd-b36d-4e47f138e4e8", "rodzic@email.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69e2b165-1e19-43db-b762-9142f39ce539", "AQAAAAEAACcQAAAAELdM+emZvFHzu+G5kccq4buD3usFV4Gv3UIjWbatimGxo1FUOwh1QdOdfXHCnC2yLA==", "3e03a593-9ba3-4579-9f03-b005c3c6e174" });

            migrationBuilder.UpdateData(
                table: "Klasy",
                keyColumn: "Id",
                keyValue: 2,
                column: "Znak",
                value: "$C");

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2021, 11, 27, 14, 31, 52, 316, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataDodania",
                value: new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
