using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class TestCategoryEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4837), new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4839), new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4850), new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4852), new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4607));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1893), new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1908), new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1910), new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1242));
        }
    }
}
