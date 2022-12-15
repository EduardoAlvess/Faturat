using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class identityUserClaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaim", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8565), new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8567), new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8577), new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8579), new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "Email", "SecurityStamp", "UserName" },
                values: new object[] { "f408058d-2eba-4341-aec8-27fdcb67e12f", new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8394), "eduardo@eduardo.com", "ade96b3d-d4fa-4294-8bca-35cc29e1eec5", "Eduardo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "Email", "SecurityStamp", "UserName" },
                values: new object[] { "0f6dd0c9-9dd7-4adb-b7c7-9c5915a7ca70", new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8409), "paulo@paulo.com", "05139f0c-6d54-4ae1-a374-2a1a9103bc65", "Paulo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUserClaim");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7718), new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7732), new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7734), new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "Email", "SecurityStamp", "UserName" },
                values: new object[] { "2efe76c6-1bc2-4bd6-a2a9-e88194dd775a", new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7481), null, "09c7941f-e0a9-475d-a8b9-ad3e0cbfa9c5", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "Email", "SecurityStamp", "UserName" },
                values: new object[] { "ee1c4fde-51b3-4da9-beb9-d389627a1dea", new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7499), null, "b2e4d4a6-fc2d-4bd9-a138-00064c567f09", null });
        }
    }
}
