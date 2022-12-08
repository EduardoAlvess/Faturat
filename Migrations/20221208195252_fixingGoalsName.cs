using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class fixingGoalsName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "CurrentBalance", "FinalBalance" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2512), 400.0, 2000.0 });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "CurrentBalance", "FinalBalance" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2514), 12000.32, 35000.720000000001 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2469), new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2472), new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2488), new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2490), new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 52, 52, 501, DateTimeKind.Local).AddTicks(2024));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "CurrentBalance", "FinalBalance" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9826), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "CurrentBalance", "FinalBalance" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9827), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9788), new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9791), new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9804), new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9805), new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9472));
        }
    }
}
