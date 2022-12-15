using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class fixAccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Goals",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Accounts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Accounts");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Balance", "CreationDate", "IconId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, 2000.0, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(602), 1, "Conta corrente", 1 },
                    { 2, 233.33000000000001, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(603), 2, "Conta PJ", 2 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Description", "IconId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(613), "Gym", 1, "ExpenseCategory" },
                    { 2, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(614), "Clothing", 2, "ExpenseCategory" },
                    { 3, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(615), "Education", 3, "ExpenseCategory" },
                    { 4, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(616), "Pet", 4, "ExpenseCategory" },
                    { 5, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(616), "Electronics", 5, "ExpenseCategory" },
                    { 6, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(617), "Health", 6, "ExpenseCategory" },
                    { 7, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(618), "Home", 7, "ExpenseCategory" },
                    { 8, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(619), "Taxes", 8, "ExpenseCategory" },
                    { 9, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(619), "Leisure", 9, "ExpenseCategory" },
                    { 10, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(620), "Others", 10, "ExpenseCategory" },
                    { 11, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(621), "Restaurant", 11, "ExpenseCategory" },
                    { 12, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(622), "Services", 12, "ExpenseCategory" },
                    { 13, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(623), "Supermarket", 13, "ExpenseCategory" },
                    { 14, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(623), "Transportation", 14, "ExpenseCategory" },
                    { 15, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(624), "Travel", 15, "ExpenseCategory" },
                    { 16, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(642), "Awards", 16, "IncomeCategory" },
                    { 17, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(642), "Gift", 17, "IncomeCategory" },
                    { 18, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(643), "Investments", 18, "IncomeCategory" },
                    { 19, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(644), "Salary", 19, "IncomeCategory" }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "CreationDate", "CurrentBalance", "FinalBalance", "FinalDate", "IconId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(731), 400.0, 2000.0, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Viagem", 1 },
                    { 2, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(733), 12000.32, 35000.720000000001, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Carro", 2 }
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
                    { 1, 1, 13, 1, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(658), "Mercado", new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Expense", 1, 250.0, false, true },
                    { 2, 2, 11, 2, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(661), "Alaminuta", new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Expense", 2, 172.34999999999999, false, false }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "Category", "CategoryId", "CreationDate", "Description", "TransactionDate", "Type", "UserId", "Value", "isDeleted", "isReceived" },
                values: new object[,]
                {
                    { 3, 1, 19, 3, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(671), "Salário", new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Income", 1, 2000.0, false, true },
                    { 4, 2, 16, 4, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(673), "Premio", new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Income", 2, 13.75, false, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Name", "Password", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(454), "Eduardo", "12345", false },
                    { 2, new DateTime(2022, 12, 4, 23, 58, 48, 420, DateTimeKind.Local).AddTicks(465), "Paulo", "54321", false }
                });
        }
    }
}
