using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diario_libruso.Data.Migrations
{
    public partial class OgloszenieDodanoPoleTresc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDodania",
                table: "Ogloszenia",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Ogloszenia",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KlasaId",
                table: "Ogloszenia",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tytul",
                table: "Ogloszenia",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogloszenia_KlasaId",
                table: "Ogloszenia",
                column: "KlasaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogloszenia_Klasy_KlasaId",
                table: "Ogloszenia",
                column: "KlasaId",
                principalTable: "Klasy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogloszenia_Klasy_KlasaId",
                table: "Ogloszenia");

            migrationBuilder.DropIndex(
                name: "IX_Ogloszenia_KlasaId",
                table: "Ogloszenia");

            migrationBuilder.DropColumn(
                name: "DataDodania",
                table: "Ogloszenia");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Ogloszenia");

            migrationBuilder.DropColumn(
                name: "KlasaId",
                table: "Ogloszenia");

            migrationBuilder.DropColumn(
                name: "Tytul",
                table: "Ogloszenia");
        }
    }
}
