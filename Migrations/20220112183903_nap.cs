using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diario_libruso.Migrations
{
    public partial class nap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "28d88ce4-83ca-4081-b2fe-1afa3bc6e687");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "c93245e4-225c-4a75-8d4f-55241b2e55f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "81a9110a-10da-493a-b53d-fa031ddbac5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "0a90ae61-4bfc-4cd4-beb0-4c731afb674a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efe42d43-b604-4654-8f7d-0987a7d945f6", "AQAAAAEAACcQAAAAEC+uWrZmPxuqbQRHYFV7fQ8Ux4invliVWqLu77r/WAmEmSxt/bmBfA1QJYdo45QUHw==", "8bf359aa-74bf-4621-94e7-070da9e64075" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31ffc243-09a5-448c-8c4a-e121d944d2c2", "AQAAAAEAACcQAAAAEPW4/yaLuAkuujXBMl1aS+QuvdW4WETSSeuKvez1OzwDYXJhl6KoTgkR8+g8Vs8fDg==", "169343a1-74af-41fe-b8ae-6bb92b3a5f09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3d9da7a-b7ac-4655-a041-44d6499070a1", "AQAAAAEAACcQAAAAEOwx21KhBwZyN9/lt47GFWaBnYdJJef7HGFMaqYvdF9Hp+7vDH2NyoChWDeqppNgCg==", "62c3885b-7f0c-40ef-a681-8820c80af231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e8052ff-8c90-40c1-934e-8de3328316d8", "AQAAAAEAACcQAAAAELorv91vsZ5KfHrIjpzs7FGNxmpaML1PQFjFeU72m98rd/0Lp1/Z6vufAqaEGYxlJw==", "894d4245-65be-49d6-b12c-549cb95b2551" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2022, 1, 12, 19, 39, 2, 966, DateTimeKind.Local).AddTicks(1830));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "9d3e8407-71a2-4ca8-a144-84f0af564826");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "4f3399e4-3a9b-4c1e-8110-6ad6c9135a49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "15ab4f33-9c95-49bb-9e0e-b02d63608fe0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "1a676461-2f75-437c-aef3-56ac39b88223");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d038cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "135550bd-2025-475b-a993-503730a3637c", "AQAAAAEAACcQAAAAEFFI0q6CpE8LPPxwDuTtdiyPTLVJMd7zFXGIf0S8Ezm8AWGuCx+8c/kFGQ5xrSVqcQ==", "4e97dd08-be58-4251-9a8c-4ed7313a225b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39dae2f3-914d-44b0-8461-658ffca48ecd", "AQAAAAEAACcQAAAAEKs/EpTjBwiEan+jV55P/e2bVqnekfknV20kUrkxJNl42YbdHjVxe9+FbMhE0uVexQ==", "85ae47fd-5f6c-4ecd-a93e-ccc374412717" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cab9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77a3a176-0b1e-4ea6-9f28-25d9457991d4", "AQAAAAEAACcQAAAAENzd8jNpskky4NHMHST4HyMLRetUCnYPryk9noVQsMH6uHk1eliPyvvohFUZ6ChVVQ==", "83913292-8092-463f-a0a6-05d25d9b5370" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e445865-a24d-6543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "731043e2-5eb4-4e96-9db1-2a9234f5d749", "AQAAAAEAACcQAAAAEEKwHH90a3UY5V/LOfHnuzuYkxOkGbO/MMcdzM+yhx5JNV3QgSNsTY99IkipqXclZA==", "0cbd37cd-3c50-4370-af57-5c16579c7dd9" });

            migrationBuilder.UpdateData(
                table: "Ogloszenia",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2022, 1, 12, 19, 33, 29, 929, DateTimeKind.Local).AddTicks(490));
        }
    }
}
