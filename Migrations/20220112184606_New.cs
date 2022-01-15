using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diario_libruso.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imie",
                table: "Uczniowie",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nazwisko",
                table: "Uczniowie",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Nauczyciele",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdentityUserId = table.Column<string>(type: "TEXT", nullable: true),
                    Imie = table.Column<string>(type: "TEXT", nullable: true),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: true),
                    KlasaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nauczyciele", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nauczyciele_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nauczyciele_Klasy_KlasaId",
                        column: x => x.KlasaId,
                        principalTable: "Klasy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Przedmioty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przedmioty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rodzice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdentityUserId = table.Column<string>(type: "TEXT", nullable: true),
                    Imie = table.Column<string>(type: "TEXT", nullable: true),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: true),
                    UczenId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rodzice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rodzice_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rodzice_Uczniowie_UczenId",
                        column: x => x.UczenId,
                        principalTable: "Uczniowie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "6acd311d-7713-48de-96af-ec1ca38c2f26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "b8ac0721-142a-4145-b83f-14e6bc0ff53a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "a814eb1e-0183-4b78-b264-fc2332b85131");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "f75160ba-b9e6-478e-90dc-5fd1e7cfac24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71ca965d-5d25-4a7a-afa7-8043154a6335", "AQAAAAEAACcQAAAAENi9+1CXRReFLClC+PzEhKA5FH+GRPslIgCItP6V8D61SY3I36obQn7Fx+SrhcrjeA==", "6752e31a-4920-4059-93bd-88c136098ce5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "766d79c6-8cd1-4764-84fa-a9f32b9ee1a3", "AQAAAAEAACcQAAAAEPja7p9d1fCXIovZBb2WlOySuOcG7wQ9m+PDR2S9yNLB9ZxuDcHVxWTuXptUboJK/Q==", "cd600f59-31c0-4416-875e-3c67fc2cc4a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "052cd717-083a-4be1-b748-68591b7fa03d", "AQAAAAEAACcQAAAAELJTSXF+/5zU0akVJj6J1hnYmGWfZ7f+vxVLoB7KjyY8W1r4fc1qSV8TrUyjHcsf+w==", "a1417089-436a-4773-bfcd-1816236df043" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0566ac43-e44f-4b4f-9d1b-83a72e8bfeff", "AQAAAAEAACcQAAAAEJenFd6GAaipjp8rxdeS4BgGXQxwk8ZN7qucw6V2LmxtRd3PTZwomO5GBlDuBBY8Lg==", "00385dcd-03ae-4188-830a-70b9e37e6eef" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2022, 1, 12, 19, 46, 5, 978, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataDodania",
                value: new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Uczniowie",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Imie", "Nazwisko" },
                values: new object[] { "Daniel", "Obajtek" });

            migrationBuilder.CreateIndex(
                name: "IX_Nauczyciele_IdentityUserId",
                table: "Nauczyciele",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nauczyciele_KlasaId",
                table: "Nauczyciele",
                column: "KlasaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rodzice_IdentityUserId",
                table: "Rodzice",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rodzice_UczenId",
                table: "Rodzice",
                column: "UczenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nauczyciele");

            migrationBuilder.DropTable(
                name: "Przedmioty");

            migrationBuilder.DropTable(
                name: "Rodzice");

            migrationBuilder.DropColumn(
                name: "Imie",
                table: "Uczniowie");

            migrationBuilder.DropColumn(
                name: "Nazwisko",
                table: "Uczniowie");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63da66ef-8ef5-4544-bb21-a7855a78ccaf", "AQAAAAEAACcQAAAAEKhZeYAt6wiyw+v9FciK4DXv77owaDEgdgRgFMld3ida/U3i2rB36RCYaR+BkamipQ==", "8159d7fa-b0df-40dd-b36d-4e47f138e4e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69e2b165-1e19-43db-b762-9142f39ce539", "AQAAAAEAACcQAAAAELdM+emZvFHzu+G5kccq4buD3usFV4Gv3UIjWbatimGxo1FUOwh1QdOdfXHCnC2yLA==", "3e03a593-9ba3-4579-9f03-b005c3c6e174" });

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
