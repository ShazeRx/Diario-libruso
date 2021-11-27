using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diario_libruso.Data.Migrations
{
    public partial class NormalizacjaUsernameDlaPrzykladowychKont : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df010c8c-e4d6-4bb4-ab0b-a6bba6ad6944", "RODZIC@EMAIL.COM", "AQAAAAEAACcQAAAAEBcV+D0KQPaLWAm8cfC9RYe2iJCc55ycb/yWwI4wc5iBzTngR0deOGp9lIO5nN1jzQ==", "238beb60-0b60-4642-a208-22639121b8ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f392f69-e543-4808-9486-3d177833c3a2", "ADMIN@EMAIL.COM", "AQAAAAEAACcQAAAAENetbKdMqlTtkJWNb3Ojj5NrVaDE3k4Bj0dMG7E3cm/E1ma9EQjA1e0asiC3A0RfWg==", "d3883eef-56f5-4b65-9264-9e09e805f54c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "63da66ef-8ef5-4544-bb21-a7855a78ccaf", "NAUCZYCIEL@EMAIL.COM", "AQAAAAEAACcQAAAAEKhZeYAt6wiyw+v9FciK4DXv77owaDEgdgRgFMld3ida/U3i2rB36RCYaR+BkamipQ==", "8159d7fa-b0df-40dd-b36d-4e47f138e4e8", "rodzic@email.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69e2b165-1e19-43db-b762-9142f39ce539", "UCZEN@EMAIL.COM", "AQAAAAEAACcQAAAAELdM+emZvFHzu+G5kccq4buD3usFV4Gv3UIjWbatimGxo1FUOwh1QdOdfXHCnC2yLA==", "3e03a593-9ba3-4579-9f03-b005c3c6e174" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2021, 11, 27, 14, 31, 52, 316, DateTimeKind.Local).AddTicks(1880));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3204c071-d820-4e16-833a-a6a7c426a7b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "c382ac05-1f70-4bf7-a1fb-5bb4d9f2d1ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "72abfb3b-f3c6-4733-93f3-6adc6ef1d177");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "d7755f97-cdf9-4f9b-a761-c43795a249ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e498f388-fdd6-4564-93c8-a54eda76dd47", null, "AQAAAAEAACcQAAAAEJ6t2H3eJCKl8JYCtXzPLSGZ2e6l9EJf9DphwyNghVUmi/TqXYUL1FyZ5MhxmfTWrg==", "7002f709-1a05-436f-b68d-844507bb58ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04a5302a-6e3c-4f92-94a9-0f543da6017e", null, "AQAAAAEAACcQAAAAEJiP25GQM5TkLEaWczr/ZDiK/94lLFskK1YjIgnyN3CeDSZ3/2EHaUEHaBIfu4ew4A==", "38583101-4738-42b7-81b0-0642c6fa5fb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "df5fe37a-8188-4ef6-9360-5633ffb4a37f", null, "AQAAAAEAACcQAAAAEA35FfuaYWgjEuYnu69H1dxsZ0NqH9ERrjw5gimJlZQi3tqhev87xHhmzD2W0AQXCQ==", "579d3664-34d7-459d-bd20-d4a769d08d0a", "nauczyciel@email.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51ff9f5d-a78b-4fac-b065-206da88d9685", null, "AQAAAAEAACcQAAAAEBUe4qIXuKREIKYp1FUt2F0/5NnnP6F5rcUQXuwNon3dZLQvnD2+X1QKnlZ4ZkwHnw==", "abea2023-c490-4f36-b0e5-72a84bd5df3e" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2021, 11, 27, 13, 49, 28, 180, DateTimeKind.Local).AddTicks(5410));
        }
    }
}
