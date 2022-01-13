using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diario_libruso.Migrations
{
    public partial class Nowe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "4e376d92-46b4-4c9d-8b4a-a28cb1dd242b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "4bb2aa13-2ffe-4cfa-a0b7-706e7fd60cfc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "0b9e4369-52e9-4d11-97ef-b0652eb7c1be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "d3d63ce5-4a0a-41f3-90b3-1481cffaf6ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87780481-8d24-401e-86e2-1d303d3b970a", "AQAAAAEAACcQAAAAEJG573TMylZYXVkxYwnicyklkrwWmEJFt7lqXOroa5xTq1LPtAyQRMn+4QBvfJgSuQ==", "a85ef4bf-634b-4c89-b280-9ed9089f740a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf017bee-6527-4913-aaa5-769da7434864", "AQAAAAEAACcQAAAAELSAHEbe6AnZMGHwqvv9KuFdsG1GgIhhp/tVxJ/tOyI40Wit+oHdxVI8MD6M7wEk2w==", "748ce43c-82e4-4ab4-a416-c075d018432a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe7a0c2a-8777-4054-9e29-8971f143f256", "AQAAAAEAACcQAAAAEMwd7UfZtLE3OnLh4uE7747aInmbPKgu4OxBRazIKlIvdC5VfYoGcO+X+fzi8XkqqQ==", "1c45dae6-9649-4260-877c-6aa576e731e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bea1018-a395-40d0-a514-8a19fe1a0ca2", "AQAAAAEAACcQAAAAEOdQmyNzmvVo5vgbJvitGa7uk+5Z3ULgxony9oA8ReafdCie1RHrmOrriU8yyamSnw==", "10255250-596e-4f1c-ae8e-513e6a064527" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2022, 1, 12, 19, 43, 14, 507, DateTimeKind.Local).AddTicks(3980));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "0975aa38-2546-465c-a0d8-df66991a4d4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "ea66703d-8754-4b36-9a42-f83996addcea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "255e3993-8d71-454c-a401-174fe26f98e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "a22d14bd-0a4e-4e6a-982c-9f9e5cdd8192");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19b58abc-d2e7-48ab-b46b-3a46d61a890e", "AQAAAAEAACcQAAAAEBcyWJ5//jjPs6ZImhYtK8poyxI+joQ5LbllRz5ie7Pi6zfEW0ovTKP7GXg5LxOGiQ==", "9e1d0fcf-5883-4561-a86b-662148b5d5e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c419fb7-bfc1-4ecc-b2f2-4b8bbc6963fd", "AQAAAAEAACcQAAAAEPJlPn3qq5dmgz44hNFQ9T84zrYoCiXJFqrEhkZKyyDdAbjL5bMnNTDJxYPKGU7y2A==", "d6597f7c-117f-467f-b603-5e8a8dbc53c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f6a4ff1-841b-47f1-9964-b68bcd15cd0e", "AQAAAAEAACcQAAAAEDZ706OVM5AJIFR5HfyEX2eEXFgpG4hSXMh3eAZZn6yMkqUi+KSVW54JnK5Ja5WfEw==", "a42e0d7c-99a8-4491-bd2b-bd14f1d8b43b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e2e2d00-9c7b-43f7-ac4d-fec8162fd7b9", "AQAAAAEAACcQAAAAEKl8A3Km6ww1RhMyXBxWL+J3mhHYIBpu0Y8+qhRGD0Knmk2jVOM6WSsN4yDJ9DiqMw==", "b64ab43a-2f7a-4145-bd6d-12fd1996e9c9" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2022, 1, 12, 19, 10, 6, 700, DateTimeKind.Local).AddTicks(8920));
        }
    }
}
