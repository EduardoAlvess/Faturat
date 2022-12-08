using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class isCompletedGoals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Goals",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 8, 16, 23, 18, 459, DateTimeKind.Local).AddTicks(9827));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Goals");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4610), new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4612), new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4623), new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4625), new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 7, 20, 13, 50, 731, DateTimeKind.Local).AddTicks(4424));
        }
    }
}
