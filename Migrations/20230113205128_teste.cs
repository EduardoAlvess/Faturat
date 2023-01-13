using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Balance = table.Column<double>(type: "double", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    isDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CurrentBalance = table.Column<double>(type: "double", nullable: false),
                    FinalBalance = table.Column<double>(type: "double", nullable: false),
                    FinalDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IdentityUserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaim", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "double", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    isDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Balance", "CreationDate", "Name", "UserId", "isDeleted" },
                values: new object[,]
                {
                    { 1, 200.0, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(3657), "Conta corrente", 1, false },
                    { 2, 2000.0, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(3659), "Conta PJ", 1, false },
                    { 3, 2000.0, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(3660), "Conta deletada", 1, true },
                    { 4, 200.0, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(3662), "Conta corrente user 2", 2, false },
                    { 5, 2000.0, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(3662), "Conta PJ user 2", 2, false },
                    { 6, 2000.0, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(3663), "Conta deletada user 2", 2, true },
                    { 7, 200.0, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(3664), "Conta corrente user 3", 3, true }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Gym", 1 },
                    { 2, "Clothing", 1 },
                    { 3, "Education", 1 },
                    { 4, "Pet", 1 },
                    { 5, "Electronics", 1 },
                    { 6, "Health", 1 },
                    { 7, "Home", 1 },
                    { 9, "Leisure", 1 },
                    { 10, "Others", 1 },
                    { 11, "Restaurant", 1 },
                    { 12, "Services", 1 },
                    { 13, "Supermarket", 1 },
                    { 14, "Transportation", 1 },
                    { 15, "Travel", 1 },
                    { 16, "Alimentation", 1 },
                    { 17, "Bills", 1 },
                    { 18, "Awards", 0 },
                    { 19, "Gift", 0 },
                    { 20, "Investments", 0 },
                    { 21, "Salary", 0 }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "CreationDate", "CurrentBalance", "FinalBalance", "FinalDate", "IsCompleted", "IsDeleted", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4170), 400.0, 2000.0, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, "Viagem", 1 },
                    { 2, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4171), 12000.32, 35000.720000000001, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, "Carro", 2 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "CategoryId", "CreationDate", "Description", "TransactionDate", "Type", "UserId", "Value", "isDeleted" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4131), "Academia", new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4131), "Expense", 1, 90.0, false },
                    { 2, 2, 8, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4133), "Imposto", new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4133), "Expense", 1, 100.0, false },
                    { 3, 4, 11, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4134), "Hamburguer", new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4135), "Expense", 2, 20.0, false },
                    { 4, 5, 8, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4135), "Imposto", new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4136), "Expense", 2, 100.0, false },
                    { 5, 1, 18, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4148), "Premio", new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4149), "Income", 1, 200.0, false },
                    { 6, 4, 19, new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4150), "Presente", new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(4150), "Income", 2, 10.0, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isDeleted" },
                values: new object[,]
                {
                    { 1, 0, "d84c137c-e451-4f83-bccf-bd6fe76ce68b", new DateTime(2023, 1, 13, 17, 51, 27, 935, DateTimeKind.Local).AddTicks(7883), "eduardo@eduardo.com", false, false, null, null, null, "$2a$11$RVK0ye4/eirJZpt04TH02Of4qUVWoMfl03d4lXPJFKjIV7cu1dT36", null, false, "8fa4ab32-5804-4059-baed-5888b8f57f90", false, "eduardo@eduardo.com", false },
                    { 2, 0, "03f9c1e8-1e72-4afa-abfb-7fcdd641084f", new DateTime(2023, 1, 13, 17, 51, 28, 89, DateTimeKind.Local).AddTicks(8403), "paulo@paulo.com", false, false, null, null, null, "$2a$11$Mkpb3IdTMvXBoxYU2bkyoulQCx7e3Z0HUwDXDqF0YELdZRbfJ4QGO", null, false, "4ee23cb7-74e0-4181-9147-b9741ce59314", false, "paulo@paulo.com", false },
                    { 3, 0, "eff551b8-85c4-474c-af1a-0097586972a3", new DateTime(2023, 1, 13, 17, 51, 28, 247, DateTimeKind.Local).AddTicks(9558), "marcos@marcos.com", false, false, null, null, null, "$2a$11$tFxXlD3ln1/DzegR.zYNCu0UlB8iGOsKkA5zh5tmu1.caOrwi1bgW", null, false, "b94051bd-0071-49cb-82f9-d50e6d08f04f", false, "marcos@marcos.com", false },
                    { 4, 0, "50136b66-6951-4902-9b71-9c31a9efed83", new DateTime(2023, 1, 13, 17, 51, 28, 399, DateTimeKind.Local).AddTicks(3141), "ronaldo@ronaldo.com", false, false, null, null, null, "$2a$11$255neBm3bSXKx6Os39to.OipTfl3hsVIbqNDb241CWPJ1yFopV/sq", null, false, "1aa50d75-e9e6-4130-b36d-757387d7a7cb", false, "ronaldo@ronaldo.com", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "IdentityUserClaim");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
