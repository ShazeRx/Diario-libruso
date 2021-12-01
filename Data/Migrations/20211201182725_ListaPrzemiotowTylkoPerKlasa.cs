using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diario_libruso.Data.Migrations
{
    public partial class ListaPrzemiotowTylkoPerKlasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Klasy_ListyPrzedmiotow_ListaPrzedmiotowId",
                table: "Klasy");

            migrationBuilder.DropForeignKey(
                name: "FK_Przedmioty_ListyPrzedmiotow_ListaPrzedmiotowId",
                table: "Przedmioty");

            migrationBuilder.DropIndex(
                name: "IX_Przedmioty_ListaPrzedmiotowId",
                table: "Przedmioty");

            migrationBuilder.DropIndex(
                name: "IX_Klasy_ListaPrzedmiotowId",
                table: "Klasy");

            migrationBuilder.DropColumn(
                name: "ListaPrzedmiotowId",
                table: "Przedmioty");

            migrationBuilder.DropColumn(
                name: "ListaPrzedmiotowId",
                table: "Klasy");

            migrationBuilder.AddColumn<int>(
                name: "KlasaId",
                table: "ListyPrzedmiotow",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ListaPrzedmiotowPrzedmiot",
                columns: table => new
                {
                    ListaPrzedmiotowId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrzedmiotyId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaPrzedmiotowPrzedmiot", x => new { x.ListaPrzedmiotowId, x.PrzedmiotyId });
                    table.ForeignKey(
                        name: "FK_ListaPrzedmiotowPrzedmiot_ListyPrzedmiotow_ListaPrzedmiotowId",
                        column: x => x.ListaPrzedmiotowId,
                        principalTable: "ListyPrzedmiotow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListaPrzedmiotowPrzedmiot_Przedmioty_PrzedmiotyId",
                        column: x => x.PrzedmiotyId,
                        principalTable: "Przedmioty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2298af0b-799b-414d-a42f-06933642d012");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "3188a276-d079-42e2-83bc-4a953c61eb91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "f86388f7-2058-4a1f-b17c-1270242c5ae0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "d01842f8-c64d-407a-8228-920472f74056");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ab67ace-519c-442c-9476-171b5364e130", "AQAAAAEAACcQAAAAEN1ObMCPvnDUIWA75xVMLl/rPSYy17pppwvX2SQIQusc1kkseNJ7YhmZ3IJpUIwR2g==", "b235fe1f-9b69-40a3-a088-08270174923c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d43d005f-b4d0-4946-bdc2-6df0950af4ce", "AQAAAAEAACcQAAAAEI5AEOcNkaGoCQOPDgXsGqom2zHPT4q8htzXg2VTHUdE0N5eYCXK5Gz4YnQr57X9RQ==", "1051b947-2dc7-4f24-b87e-f8288abeabd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67d5e535-8142-4c7e-bdb9-3fde7b6e110c", "AQAAAAEAACcQAAAAEHwkn6RmnyYipDu02ENt8nokl1R6Gga8esUSfWL3IdlqJsNTmLyplN47hcMWThFu2w==", "fee82552-9ea2-4489-a528-a4f817039bd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77e1afa0-124e-40ce-8c02-a7f2c5ff8a44", "AQAAAAEAACcQAAAAEHdXFsXYu6e+1dCXx00Cgus91sSoQ2GRo02g89xo3RqGzn3JrnxOP+iKtWp19m2+aw==", "c1cd922e-e209-47fd-a38c-cdb8dc08b719" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2021, 12, 1, 19, 27, 23, 983, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.CreateIndex(
                name: "IX_ListyPrzedmiotow_KlasaId",
                table: "ListyPrzedmiotow",
                column: "KlasaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaPrzedmiotowPrzedmiot_PrzedmiotyId",
                table: "ListaPrzedmiotowPrzedmiot",
                column: "PrzedmiotyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListyPrzedmiotow_Klasy_KlasaId",
                table: "ListyPrzedmiotow",
                column: "KlasaId",
                principalTable: "Klasy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListyPrzedmiotow_Klasy_KlasaId",
                table: "ListyPrzedmiotow");

            migrationBuilder.DropTable(
                name: "ListaPrzedmiotowPrzedmiot");

            migrationBuilder.DropIndex(
                name: "IX_ListyPrzedmiotow_KlasaId",
                table: "ListyPrzedmiotow");

            migrationBuilder.DropColumn(
                name: "KlasaId",
                table: "ListyPrzedmiotow");

            migrationBuilder.AddColumn<int>(
                name: "ListaPrzedmiotowId",
                table: "Przedmioty",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ListaPrzedmiotowId",
                table: "Klasy",
                type: "INTEGER",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e52b059-d2e9-40e5-bf4e-6a9605cbc355", "AQAAAAEAACcQAAAAEPzjGjAo/Ns5GmpfNj9dQIa55azy88lhDU+aAvv76AbNZitPJO1t+X22QK96iTSkeA==", "eebac68b-57e0-4434-af71-684cb859b8a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d85831b-fc7a-423a-9eee-9581f0d37c8f", "AQAAAAEAACcQAAAAECU/6FKksi604coXnCu8ZJsmsWGB5HEojLDRKjNkisoGJlBkL6LWYRe4KGJpUvhl3Q==", "a262184f-ef3a-4e3c-97a4-dc6e6719809d" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2021, 12, 1, 9, 51, 52, 42, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.CreateIndex(
                name: "IX_Przedmioty_ListaPrzedmiotowId",
                table: "Przedmioty",
                column: "ListaPrzedmiotowId");

            migrationBuilder.CreateIndex(
                name: "IX_Klasy_ListaPrzedmiotowId",
                table: "Klasy",
                column: "ListaPrzedmiotowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Klasy_ListyPrzedmiotow_ListaPrzedmiotowId",
                table: "Klasy",
                column: "ListaPrzedmiotowId",
                principalTable: "ListyPrzedmiotow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Przedmioty_ListyPrzedmiotow_ListaPrzedmiotowId",
                table: "Przedmioty",
                column: "ListaPrzedmiotowId",
                principalTable: "ListyPrzedmiotow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
