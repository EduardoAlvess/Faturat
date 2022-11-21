using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class TransactionDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1208), new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1210), new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1221), new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1222), new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1050));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionDate",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 34, 53, 19, DateTimeKind.Local).AddTicks(2458));
        }
    }
}
