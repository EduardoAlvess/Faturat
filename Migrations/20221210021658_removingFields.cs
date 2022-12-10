using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class removingFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

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
                columns: new[] { "ConcurrencyStamp", "CreationDate", "SecurityStamp" },
                values: new object[] { "2efe76c6-1bc2-4bd6-a2a9-e88194dd775a", new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7481), "09c7941f-e0a9-475d-a8b9-ad3e0cbfa9c5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "SecurityStamp" },
                values: new object[] { "ee1c4fde-51b3-4da9-beb9-d389627a1dea", new DateTime(2022, 12, 9, 23, 16, 58, 113, DateTimeKind.Local).AddTicks(7499), "b2e4d4a6-fc2d-4bd9-a138-00064c567f09" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1013), new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1015), new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1027), new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1029), new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "Name", "Password", "SecurityStamp" },
                values: new object[] { "a8d98042-6a72-42ac-b44d-f9aaea03413a", new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(753), "Eduardo", "12345", "f676ecbb-4e06-48c5-925c-7f9bbc00a5c5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "Name", "Password", "SecurityStamp" },
                values: new object[] { "3c333de2-65d6-451d-b81b-a57420f2ae5c", new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(771), "Paulo", "54321", "8397620c-e8dd-4440-aa3a-b5b25b3f5a65" });
        }
    }
}
