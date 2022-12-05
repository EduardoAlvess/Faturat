using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class TestCategoryEnum2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "CreationDate", "TransactionDate" },
                values: new object[] { 1, new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9614), new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9617), new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9629), new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9631), new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9410));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Category", "CreationDate", "TransactionDate" },
                values: new object[] { 0, new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4837), new DateTime(2022, 12, 4, 22, 47, 11, 305, DateTimeKind.Local).AddTicks(4837) });

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
    }
}
