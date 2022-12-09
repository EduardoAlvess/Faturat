using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class identity4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Balance", "CreationDate", "IconId", "Name", "UserId", "isDeleted" },
                values: new object[,]
                {
                    { 1, 2000.0, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7394), 1, "Conta corrente", 1, false },
                    { 2, 233.33000000000001, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7397), 2, "Conta PJ", 2, false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Description", "IconId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7411), "Gym", 1, "ExpenseCategory" },
                    { 2, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7412), "Clothing", 2, "ExpenseCategory" },
                    { 3, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7414), "Education", 3, "ExpenseCategory" },
                    { 4, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7415), "Pet", 4, "ExpenseCategory" },
                    { 5, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7416), "Electronics", 5, "ExpenseCategory" },
                    { 6, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7417), "Health", 6, "ExpenseCategory" },
                    { 7, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7418), "Home", 7, "ExpenseCategory" },
                    { 8, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7418), "Taxes", 8, "ExpenseCategory" },
                    { 9, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7419), "Leisure", 9, "ExpenseCategory" },
                    { 10, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7420), "Others", 10, "ExpenseCategory" },
                    { 11, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7420), "Restaurant", 11, "ExpenseCategory" },
                    { 12, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7422), "Services", 12, "ExpenseCategory" },
                    { 13, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7422), "Supermarket", 13, "ExpenseCategory" },
                    { 14, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7423), "Transportation", 14, "ExpenseCategory" },
                    { 15, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7424), "Travel", 15, "ExpenseCategory" },
                    { 16, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7442), "Awards", 16, "IncomeCategory" },
                    { 17, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7443), "Gift", 17, "IncomeCategory" },
                    { 18, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7444), "Investments", 18, "IncomeCategory" },
                    { 19, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7445), "Salary", 19, "IncomeCategory" }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "CreationDate", "CurrentBalance", "FinalBalance", "FinalDate", "IconId", "IsCompleted", "IsDeleted", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7495), 400.0, 2000.0, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, false, "Viagem", 1 },
                    { 2, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7497), 12000.32, 35000.720000000001, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, false, "Carro", 2 }
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
                    { 1, 1, 13, 1, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7458), "Mercado", new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7459), "Expense", 1, 250.0, false, true },
                    { 2, 2, 11, 2, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7461), "Alaminuta", new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7461), "Expense", 2, 172.34999999999999, false, false }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "Category", "CategoryId", "CreationDate", "Description", "TransactionDate", "Type", "UserId", "Value", "isDeleted", "isReceived" },
                values: new object[,]
                {
                    { 3, 1, 19, 3, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7477), "Salário", new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7478), "Income", 1, 2000.0, false, true },
                    { 4, 2, 16, 4, new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7479), "Premio", new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7479), "Income", 2, 13.75, false, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isDeleted" },
                values: new object[,]
                {
                    { 1, 0, "907b1b3d-9cbd-450f-aef9-1cd28284723a", new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7171), null, false, false, null, "Eduardo", null, null, "12345", null, null, false, "9507f372-b84d-4a00-80ae-12f273200a7e", false, null, false },
                    { 2, 0, "448cad2f-da30-4aa5-9279-ea12d22b78a3", new DateTime(2022, 12, 9, 17, 13, 57, 773, DateTimeKind.Local).AddTicks(7204), null, false, false, null, "Paulo", null, null, "54321", null, null, false, "aaff9f4e-aa87-4970-b997-b7de3582066b", false, null, false }
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
