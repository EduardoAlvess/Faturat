using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class recreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Balance", "CreationDate", "IconId", "Name", "UserId", "isDeleted" },
                values: new object[,]
                {
                    { 1, 2000.0, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1228), 1, "Conta corrente", 1, false },
                    { 2, 233.33000000000001, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1229), 2, "Conta PJ", 2, false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Description", "IconId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1242), "Gym", 1, "ExpenseCategory" },
                    { 2, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1243), "Clothing", 2, "ExpenseCategory" },
                    { 3, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1244), "Education", 3, "ExpenseCategory" },
                    { 4, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1244), "Pet", 4, "ExpenseCategory" },
                    { 5, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1245), "Electronics", 5, "ExpenseCategory" },
                    { 6, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1246), "Health", 6, "ExpenseCategory" },
                    { 7, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1246), "Home", 7, "ExpenseCategory" },
                    { 8, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1247), "Taxes", 8, "ExpenseCategory" },
                    { 9, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1248), "Leisure", 9, "ExpenseCategory" },
                    { 10, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1249), "Others", 10, "ExpenseCategory" },
                    { 11, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1249), "Restaurant", 11, "ExpenseCategory" },
                    { 12, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1250), "Services", 12, "ExpenseCategory" },
                    { 13, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1251), "Supermarket", 13, "ExpenseCategory" },
                    { 14, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1252), "Transportation", 14, "ExpenseCategory" },
                    { 15, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1253), "Travel", 15, "ExpenseCategory" },
                    { 16, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1275), "Awards", 16, "IncomeCategory" },
                    { 17, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1276), "Gift", 17, "IncomeCategory" },
                    { 18, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1277), "Investments", 18, "IncomeCategory" },
                    { 19, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1278), "Salary", 19, "IncomeCategory" }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "CreationDate", "CurrentBalance", "FinalBalance", "FinalDate", "IconId", "IsCompleted", "IsDeleted", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1324), 400.0, 2000.0, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, false, "Viagem", 1 },
                    { 2, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1326), 12000.32, 35000.720000000001, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, false, "Carro", 2 }
                });

            migrationBuilder.InsertData(
                table: "Icons",
                columns: new[] { "Id", "ImageName" },
                values: new object[,]
                {
                    { 1, "img1.jpg" },
                    { 2, "img2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "Category", "CategoryId", "CreationDate", "Description", "TransactionDate", "Type", "UserId", "Value", "isDeleted", "isPaid" },
                values: new object[,]
                {
                    { 1, 1, 13, 1, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1292), "Mercado", new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1292), "Expense", 1, 250.0, false, true },
                    { 2, 2, 11, 2, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1294), "Alaminuta", new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1294), "Expense", 2, 172.34999999999999, false, false }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "Category", "CategoryId", "CreationDate", "Description", "TransactionDate", "Type", "UserId", "Value", "isDeleted", "isReceived" },
                values: new object[,]
                {
                    { 3, 1, 19, 3, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1308), "Salário", new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1308), "Income", 1, 2000.0, false, true },
                    { 4, 2, 16, 4, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1309), "Premio", new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1309), "Income", 2, 13.75, false, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Name", "Password", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1022), "Eduardo", "12345", false },
                    { 2, new DateTime(2022, 12, 8, 17, 18, 25, 964, DateTimeKind.Local).AddTicks(1038), "Paulo", "54321", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
