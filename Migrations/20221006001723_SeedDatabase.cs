using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isRecived",
                table: "Transactions",
                newName: "isReceived");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Icons",
                newName: "ImageName");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Goals",
                newName: "FinalAmount");

            migrationBuilder.AddColumn<double>(
                name: "CurrentAmount",
                table: "Goals",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Balance", "CreationDate", "IconId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, 2000.0, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6369), 1, "Conta corrente", 1 },
                    { 2, 233.33000000000001, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6371), 2, "Conta PJ", 2 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Description", "IconId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6381), "Supermarket", 1, "ExpenseCategory" },
                    { 2, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6382), "Restaurant", 2, "ExpenseCategory" },
                    { 3, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6390), "Salary", 1, "IncomeCategory" },
                    { 4, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6391), "Award", 2, "IncomeCategory" }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "CreationDate", "CurrentAmount", "FinalAmount", "FinalDate", "IconId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6430), 400.0, 2000.0, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Viagem", 1 },
                    { 2, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6431), 12000.32, 35000.720000000001, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Carro", 2 }
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
                columns: new[] { "Id", "AccountId", "CategoryId", "CreationDate", "Description", "Type", "UserId", "Value", "isDeleted", "isPaid" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6405), "Mercado", "Expense", 1, 250.0, false, true },
                    { 2, 2, 2, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6407), "Alaminuta", "Expense", 2, 172.34999999999999, false, false }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "CategoryId", "CreationDate", "Description", "Type", "UserId", "Value", "isDeleted", "isReceived" },
                values: new object[,]
                {
                    { 3, 1, 3, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6415), "Salário", "Income", 1, 2000.0, false, true },
                    { 4, 2, 4, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6416), "Premio", "Income", 2, 13.75, false, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Name", "Password", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6242), "Eduardo", "12345", false },
                    { 2, new DateTime(2022, 10, 5, 21, 17, 23, 432, DateTimeKind.Local).AddTicks(6251), "Paulo", "54321", false }
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

            migrationBuilder.DropColumn(
                name: "CurrentAmount",
                table: "Goals");

            migrationBuilder.RenameColumn(
                name: "isReceived",
                table: "Transactions",
                newName: "isRecived");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Icons",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "FinalAmount",
                table: "Goals",
                newName: "Amount");
        }
    }
}
