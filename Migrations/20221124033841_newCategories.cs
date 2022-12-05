using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class newCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

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
                columns: new[] { "CreationDate", "Description" },
                values: new object[] { new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1634), "Gym" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Description" },
                values: new object[] { new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1636), "Clothing" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Description", "IconId", "Type" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1637), "Education", 3, "ExpenseCategory" },
                    { 4, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1637), "Pet", 4, "ExpenseCategory" },
                    { 5, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1638), "Electronics", 5, "ExpenseCategory" },
                    { 6, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1639), "Health", 6, "ExpenseCategory" },
                    { 7, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1639), "Home", 7, "ExpenseCategory" },
                    { 8, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1640), "Taxes", 8, "ExpenseCategory" },
                    { 9, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1641), "Leisure", 9, "ExpenseCategory" },
                    { 10, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1641), "Others", 10, "ExpenseCategory" },
                    { 11, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1642), "Restaurant", 11, "ExpenseCategory" },
                    { 12, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1643), "Services", 12, "ExpenseCategory" },
                    { 13, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1644), "Supermarket", 13, "ExpenseCategory" },
                    { 14, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1645), "Transportation", 14, "ExpenseCategory" },
                    { 15, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1645), "Travel", 15, "ExpenseCategory" },
                    { 16, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1869), "Awards", 16, "IncomeCategory" },
                    { 17, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1870), "Gift", 17, "IncomeCategory" },
                    { 18, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1873), "Investments", 18, "IncomeCategory" },
                    { 19, new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1874), "Salary", 19, "IncomeCategory" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

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
                columns: new[] { "CreationDate", "Description" },
                values: new object[] { new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1186), "Supermarket" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Description" },
                values: new object[] { new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1187), "Restaurant" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Description", "IconId", "Type" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1195), "Salary", 1, "IncomeCategory" },
                    { 4, new DateTime(2022, 11, 8, 22, 41, 36, 142, DateTimeKind.Local).AddTicks(1196), "Award", 2, "IncomeCategory" }
                });

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
    }
}
