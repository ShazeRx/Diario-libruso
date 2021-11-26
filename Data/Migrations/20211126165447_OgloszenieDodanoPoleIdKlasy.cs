using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diario_libruso.Data.Migrations
{
    public partial class OgloszenieDodanoPoleIdKlasy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogloszenia_Klasy_KlasaId",
                table: "Ogloszenia");
            
            migrationBuilder.AddForeignKey(
                name: "FK_Ogloszenia_Klasy_KlasaId",
                table: "Ogloszenia",
                column: "KlasaId",
                principalTable: "Klasy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.InsertData(
                table: "Klasy",
                columns: new[] { "Id", "RokPoczatkowy", "Znak" },
                values: new object[] { 1, 2016, "3C" });

            migrationBuilder.InsertData(
                table: "Klasy",
                columns: new[] { "Id", "RokPoczatkowy", "Znak" },
                values: new object[] { 2, 2015, "$C" });

            migrationBuilder.InsertData(
                table: "Ogloszenia",
                columns: new[] { "Id", "DataDodania", "Discriminator", "Tresc", "Tytul" },
                values: new object[] { 5, new DateTime(2021, 11, 26, 17, 54, 45, 894, DateTimeKind.Local).AddTicks(5280), "Ogloszenie", "Bardzo wazne", "Wazne!!!" });

            migrationBuilder.InsertData(
                table: "Ogloszenia",
                columns: new[] { "Id", "DataDodania", "Discriminator", "KlasaId", "Tresc", "Tytul" },
                values: new object[] { 6, new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "OgloszenieKlasowe", 1, "Super wazne", "Mega wazne" });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogloszenia_Klasy_KlasaId",
                table: "Ogloszenia");

            migrationBuilder.DeleteData(
                table: "Klasy",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Klasy",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogloszenia_Klasy_KlasaId",
                table: "Ogloszenia",
                column: "KlasaId",
                principalTable: "Klasy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
