using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diario_libruso.Data.Migrations
{
    public partial class Students : Migration
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "d046015f-ed81-4758-abf3-540888b4eb1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "76083745-c683-43c7-aea9-a237ef686741");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "98824f96-a23b-4f7e-b2a0-e06a8369da7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "3a46878a-5bd5-4e3c-b764-55bed0efb46d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fa43ee1-dfee-4e95-878b-740953d18a42", "AQAAAAEAACcQAAAAEHHp77ian0qWA6OLLoYxMERNgZuTIfjs7SmtC8EYHHM61eMYcouovk7ebWFMbh4YdQ==", "aed9acc8-19c4-4e66-b1b6-19cf12439912" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6be7d222-d65b-4ee4-bd97-1d4f395ea6e8", "AQAAAAEAACcQAAAAEN7AjMeRnxetrpzK5trgWQ7WMd1Y4BXDLz8bY2lAF8IycGIkw+LgOM8JErzIdrWqCQ==", "8900705d-5eea-4982-885b-c1389779d094" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca455096-7bf7-4039-9db4-51df72acf97a", "AQAAAAEAACcQAAAAENRvumeT+ZDs/RWzys7vFiNNrm2ze1XDQBlRiw0PufVnZnR6TWJFDKYYCnpGpkrmHg==", "160f6434-4194-458b-aef0-eea8b1d0a0b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b254fd5-a740-45df-bef4-bb332909dd14", "AQAAAAEAACcQAAAAENMsdNQU+YZF8b0E5oDUFeCcEUN4sD2JrjL6uRYTdoQXAYWWTUzR63PRzOpGLbjPkQ==", "bbc2c4e3-3b68-4e33-aa42-1e4a729116c1" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2022, 1, 11, 19, 35, 39, 822, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataDodania",
                value: new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Uczniowie",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Imie", "Nazwisko" },
                values: new object[] { "Daniel", "Obajtek" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
