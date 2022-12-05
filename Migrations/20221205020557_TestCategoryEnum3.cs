using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class TestCategoryEnum3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "CreationDate", "TransactionDate" },
                values: new object[] { 13, new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7518), new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "CreationDate", "TransactionDate" },
                values: new object[] { 11, new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7520), new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "CreationDate", "TransactionDate" },
                values: new object[] { 19, new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7541), new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "CreationDate", "TransactionDate" },
                values: new object[] { 16, new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7543), new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7249));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Category", "CreationDate", "TransactionDate" },
                values: new object[] { 0, new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9617), new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "CreationDate", "TransactionDate" },
                values: new object[] { 0, new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9629), new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "CreationDate", "TransactionDate" },
                values: new object[] { 0, new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9631), new DateTime(2022, 12, 4, 22, 58, 18, 775, DateTimeKind.Local).AddTicks(9631) });

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
    }
}
