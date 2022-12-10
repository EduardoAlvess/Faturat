using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class passwordHash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8827), new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8853), new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8856), new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8be495b8-fff3-4e69-bf17-4a35e38cd52d", new DateTime(2022, 12, 10, 1, 18, 54, 946, DateTimeKind.Local).AddTicks(329), "$2a$11$.igG358.7M7FosKnGr2Og.ufde93RSKxnp7b4UYM2y1VT7JfHotoG", "7a76d344-65b6-4474-99e7-ff09a9d58691", "eduardo@eduardo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "98d6f846-8ddc-4dac-b815-04bcd696b20d", new DateTime(2022, 12, 10, 1, 18, 55, 145, DateTimeKind.Local).AddTicks(8160), "$2a$11$nrolKsVmdNVwX2MASJIUdeTrFfXsKLmvER2g8l3vadOjlQugV0Oui", "e1a59ffd-9cf6-4ce4-820d-7f457fe28daa", "paulo@paulo.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f408058d-2eba-4341-aec8-27fdcb67e12f", new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8394), null, "ade96b3d-d4fa-4294-8bca-35cc29e1eec5", "Eduardo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0f6dd0c9-9dd7-4adb-b7c7-9c5915a7ca70", new DateTime(2022, 12, 9, 23, 49, 32, 388, DateTimeKind.Local).AddTicks(8409), null, "05139f0c-6d54-4ae1-a374-2a1a9103bc65", "Paulo" });
        }
    }
}
