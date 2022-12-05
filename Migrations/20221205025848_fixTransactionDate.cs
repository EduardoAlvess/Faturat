using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class fixTransactionDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(658), new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(661), new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(671), new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(673), new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(465));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7518), new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7520), new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7541), new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "TransactionDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7543), new DateTime(2022, 12, 4, 23, 5, 56, 630, DateTimeKind.Local).AddTicks(7543) });

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
    }
}
