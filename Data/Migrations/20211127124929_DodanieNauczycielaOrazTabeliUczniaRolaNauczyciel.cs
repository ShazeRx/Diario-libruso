using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diario_libruso.Data.Migrations
{
    public partial class DodanieNauczycielaOrazTabeliUczniaRolaNauczyciel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7213", "d7755f97-cdf9-4f9b-a761-c43795a249ca", "Nauczyciel", "NAUCZYCIEL" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e498f388-fdd6-4564-93c8-a54eda76dd47", "AQAAAAEAACcQAAAAEJ6t2H3eJCKl8JYCtXzPLSGZ2e6l9EJf9DphwyNghVUmi/TqXYUL1FyZ5MhxmfTWrg==", "7002f709-1a05-436f-b68d-844507bb58ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04a5302a-6e3c-4f92-94a9-0f543da6017e", "AQAAAAEAACcQAAAAEJiP25GQM5TkLEaWczr/ZDiK/94lLFskK1YjIgnyN3CeDSZ3/2EHaUEHaBIfu4ew4A==", "38583101-4738-42b7-81b0-0642c6fa5fb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51ff9f5d-a78b-4fac-b065-206da88d9685", "AQAAAAEAACcQAAAAEBUe4qIXuKREIKYp1FUt2F0/5NnnP6F5rcUQXuwNon3dZLQvnD2+X1QKnlZ4ZkwHnw==", "abea2023-c490-4f36-b0e5-72a84bd5df3e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e445865-a24d-6543-a6c6-9443d048cab9", 0, "df5fe37a-8188-4ef6-9360-5633ffb4a37f", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEA35FfuaYWgjEuYnu69H1dxsZ0NqH9ERrjw5gimJlZQi3tqhev87xHhmzD2W0AQXCQ==", null, false, "579d3664-34d7-459d-bd20-d4a769d08d0a", false, "nauczyciel@email.com" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2021, 11, 27, 13, 49, 28, 180, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.InsertData(
                table: "Uczniowie",
                columns: new[] { "Id", "IdentityUserId", "KlasaId", "NumerDziennika" },
                values: new object[] { 87, "e445865-a24d-6543-a6c6-9443d048cdb9", 1, 2 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7213", "e445865-a24d-6543-a6c6-9443d048cab9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7213", "e445865-a24d-6543-a6c6-9443d048cab9" });

            migrationBuilder.DeleteData(
                table: "Uczniowie",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "dd099dfb-2abb-40da-b6dd-42b0b34ef7ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "a1b20d82-da19-477c-8736-2599447a586c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "f4ef272c-b4e7-45a6-bbf0-9ffd77cc1086");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73fbb714-8a2b-445f-9ec2-b8afda1dc8e7", "AQAAAAEAACcQAAAAEJSIz1nfESouBvv/Cp/8xViiBmK8VEgp0rcCsOEKAOEUMeod9zmAT4c9jqlVKpCivQ==", "289f49ec-9a88-4314-932b-1290ca596b06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "617d5c47-7f59-4c2b-8f76-36ccff878aa8", "AQAAAAEAACcQAAAAEGt7yC6SX0OwsmiUjpyPQ3RsXGxVTRjfoVLaPz5v3TAga9o7H8zdK89JEP/joOwgkg==", "54c0f7d5-0521-4cb7-b69a-31a42d7d9390" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ad29ea3-679b-40e0-aa82-166c24e25a8c", "AQAAAAEAACcQAAAAEFePYIswn2qBSSqH0wN2GEhRooVnM/rxHa172NRnlkiAa4jCjRWteLjoNan+icsnmg==", "34d184a3-12e3-4a99-bc4e-4da7c85b146f" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2021, 11, 27, 13, 19, 37, 967, DateTimeKind.Local).AddTicks(9040));
        }
    }
}
