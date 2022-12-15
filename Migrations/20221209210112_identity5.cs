using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class identity5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Balance", "CreationDate", "IconId", "Name", "UserId", "isDeleted" },
                values: new object[,]
                {
                    { 1, 2000.0, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(947), 1, "Conta corrente", 1, false },
                    { 2, 233.33000000000001, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(949), 2, "Conta PJ", 2, false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Description", "IconId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(962), "Gym", 1, "ExpenseCategory" },
                    { 2, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(964), "Clothing", 2, "ExpenseCategory" },
                    { 3, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(965), "Education", 3, "ExpenseCategory" },
                    { 4, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(965), "Pet", 4, "ExpenseCategory" },
                    { 5, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(966), "Electronics", 5, "ExpenseCategory" },
                    { 6, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(967), "Health", 6, "ExpenseCategory" },
                    { 7, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(968), "Home", 7, "ExpenseCategory" },
                    { 8, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(969), "Taxes", 8, "ExpenseCategory" },
                    { 9, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(970), "Leisure", 9, "ExpenseCategory" },
                    { 10, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(971), "Others", 10, "ExpenseCategory" },
                    { 11, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(972), "Restaurant", 11, "ExpenseCategory" },
                    { 12, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(974), "Services", 12, "ExpenseCategory" },
                    { 13, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(974), "Supermarket", 13, "ExpenseCategory" },
                    { 14, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(975), "Transportation", 14, "ExpenseCategory" },
                    { 15, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(976), "Travel", 15, "ExpenseCategory" },
                    { 16, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(995), "Awards", 16, "IncomeCategory" },
                    { 17, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(996), "Gift", 17, "IncomeCategory" },
                    { 18, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(997), "Investments", 18, "IncomeCategory" },
                    { 19, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(998), "Salary", 19, "IncomeCategory" }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "CreationDate", "CurrentBalance", "FinalBalance", "FinalDate", "IconId", "IsCompleted", "IsDeleted", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1048), 400.0, 2000.0, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, false, "Viagem", 1 },
                    { 2, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1050), 12000.32, 35000.720000000001, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, false, "Carro", 2 }
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
                    { 1, 1, 13, 1, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1013), "Mercado", new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1013), "Expense", 1, 250.0, false, true },
                    { 2, 2, 11, 2, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1015), "Alaminuta", new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1016), "Expense", 2, 172.34999999999999, false, false }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "Category", "CategoryId", "CreationDate", "Description", "TransactionDate", "Type", "UserId", "Value", "isDeleted", "isReceived" },
                values: new object[,]
                {
                    { 3, 1, 19, 3, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1027), "Salário", new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1027), "Income", 1, 2000.0, false, true },
                    { 4, 2, 16, 4, new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1029), "Premio", new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(1029), "Income", 2, 13.75, false, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isDeleted" },
                values: new object[,]
                {
                    { 1, 0, "a8d98042-6a72-42ac-b44d-f9aaea03413a", new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(753), null, false, false, null, "Eduardo", null, null, "12345", null, null, false, "f676ecbb-4e06-48c5-925c-7f9bbc00a5c5", false, null, false },
                    { 2, 0, "3c333de2-65d6-451d-b81b-a57420f2ae5c", new DateTime(2022, 12, 9, 18, 1, 12, 26, DateTimeKind.Local).AddTicks(771), null, false, false, null, "Paulo", null, null, "54321", null, null, false, "8397620c-e8dd-4440-aa3a-b5b25b3f5a65", false, null, false }
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
