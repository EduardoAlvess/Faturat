using Microsoft.EntityFrameworkCore;
using TCC.Areas.Identity.Data;
using TCC.Models;
using BCrypt.Net;

namespace TCC.Db
{
    public static class DbSeeder
    {
        public static void SeedTables(ModelBuilder builder)
        {
            SeedUsers(builder);
            SeedAccounts(builder);
            SeedCategories(builder);
            SeedTransactions(builder);
            SeedGoals(builder);
        }

        private static void SeedUsers(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "eduardo@eduardo.com",
                    Email = "eduardo@eduardo.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("eduardo123"),
                    isDeleted = false,
                    CreationDate = DateTime.Now
                },
                new User
                {
                    Id = 2,
                    UserName = "paulo@paulo.com",
                    Email = "paulo@paulo.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("paulo123"),
                    isDeleted = false,
                    CreationDate = DateTime.Now
                },
                new User
                {
                    Id = 3,
                    UserName = "marcos@marcos.com",
                    Email = "marcos@marcos.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("marcos123"),
                    isDeleted = false,
                    CreationDate = DateTime.Now
                },
                new User
                {
                    Id = 4,
                    UserName = "ronaldo@ronaldo.com",
                    Email = "ronaldo@ronaldo.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("ronaldo123"),
                    isDeleted = true,
                    CreationDate = DateTime.Now
                });
        }

        private static void SeedAccounts(ModelBuilder builder)
        {
            builder.Entity<Account>().HasData(
                new Account
                {
                    Id = 1,
                    UserId = 1,
                    Name = "Conta corrente",
                    Balance = 200,
                    CreationDate = DateTime.Now,
                    isDeleted = false
                },
                new Account
                {
                    Id = 2,
                    UserId = 1,
                    Name = "Conta PJ",
                    Balance = 2000,
                    CreationDate = DateTime.Now,
                    isDeleted = false
                },
                new Account
                {
                    Id = 3,
                    UserId = 1,
                    Name = "Conta deletada",
                    Balance = 2000,
                    CreationDate = DateTime.Now,
                    isDeleted = true
                },
                new Account
                {
                    Id = 4,
                    UserId = 2,
                    Name = "Conta corrente user 2",
                    Balance = 200,
                    CreationDate = DateTime.Now,
                    isDeleted = false
                },
                new Account
                {
                    Id = 5,
                    UserId = 2,
                    Name = "Conta PJ user 2",
                    Balance = 2000,
                    CreationDate = DateTime.Now,
                    isDeleted = false
                },
                new Account
                {
                    Id = 6,
                    UserId = 2,
                    Name = "Conta deletada user 2",
                    Balance = 2000,
                    CreationDate = DateTime.Now,
                    isDeleted = true
                },
                new Account
                {
                    Id = 7,
                    UserId = 3,
                    Name = "Conta corrente user 3",
                    Balance = 200,
                    CreationDate = DateTime.Now,
                    isDeleted = true
                });
        }

        private static void SeedCategories(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = CategoryId.Gym,
                    Name = CategoryId.Gym.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Clothing,
                    Name = CategoryId.Clothing.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Education,
                    Name = CategoryId.Education.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Pet,
                    Name = CategoryId.Pet.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Electronics,
                    Name = CategoryId.Electronics.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Health,
                    Name = CategoryId.Health.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Home,
                    Name = CategoryId.Home.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Leisure,
                    Name = CategoryId.Leisure.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Others,
                    Name = CategoryId.Others.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Restaurant,
                    Name = CategoryId.Restaurant.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Services,
                    Name = CategoryId.Services.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Supermarket,
                    Name = CategoryId.Supermarket.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Transportation,
                    Name = CategoryId.Transportation.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Travel,
                    Name = CategoryId.Travel.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Alimentation,
                    Name = CategoryId.Alimentation.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Bills,
                    Name = CategoryId.Bills.ToString(),
                    Type = CategoryType.Expense,
                },
                new Category
                {
                    Id = CategoryId.Awards,
                    Name = CategoryId.Awards.ToString(),
                    Type = CategoryType.Income,
                },
                new Category
                {
                    Id = CategoryId.Gift,
                    Name = CategoryId.Gift.ToString(),
                    Type = CategoryType.Income,
                },
                new Category
                {
                    Id = CategoryId.Investments,
                    Name = CategoryId.Investments.ToString(),
                    Type = CategoryType.Income,
                },
                new Category
                {
                    Id = CategoryId.Salary,
                    Name = CategoryId.Salary.ToString(),
                    Type = CategoryType.Income,
                });
        }

        private static void SeedTransactions(ModelBuilder builder)
        {
            builder.Entity<Expense>().HasData(
                new Expense
                {
                    Id = 1,
                    UserId = 1,
                    AccountId = 1,
                    CategoryId = CategoryId.Gym,
                    Value = 90,
                    Description = "Academia",
                    isDeleted = false,
                    CreationDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                },
                new Expense
                {
                    Id = 2,
                    UserId = 1,
                    AccountId = 2,
                    CategoryId = CategoryId.Taxes,
                    Value = 100,
                    Description = "Imposto",
                    isDeleted = false,
                    CreationDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                },
                new Expense
                {
                    Id = 3,
                    UserId = 2,
                    AccountId = 4,
                    CategoryId = CategoryId.Restaurant,
                    Value = 20,
                    Description = "Hamburguer",
                    isDeleted = false,
                    CreationDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                },
                new Expense
                {
                    Id = 4,
                    UserId = 2,
                    AccountId = 5,
                    CategoryId = CategoryId.Taxes,
                    Value = 100,
                    Description = "Imposto",
                    isDeleted = false,
                    CreationDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                });
            builder.Entity<Income>().HasData(
                new Income
                {
                    Id = 5,
                    UserId = 1,
                    AccountId = 1,
                    CategoryId = CategoryId.Awards,
                    Value = 200,
                    Description = "Premio",
                    isDeleted = false,
                    CreationDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                },
                new Income
                {
                    Id = 6,
                    UserId = 2,
                    AccountId = 4,
                    CategoryId = CategoryId.Gift,
                    Value = 10,
                    Description = "Presente",
                    isDeleted = false,
                    CreationDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                });
        }

        private static void SeedGoals(ModelBuilder builder)
        {
            builder.Entity<Goal>().HasData(
                new Goal
                {
                    Id = 1,
                    UserId = 1,
                    Name = "Viagem",
                    FinalBalance = 2000,
                    CurrentBalance = 400,
                    FinalDate = new DateTime(2023, 01, 15),
                    CreationDate = DateTime.Now,
                    IsCompleted = false,
                    IsDeleted = false
                },
                new Goal
                {
                    Id = 2,
                    UserId = 2,
                    Name = "Carro",
                    FinalBalance = 35000.72,
                    CurrentBalance = 12000.32,
                    FinalDate = new DateTime(2023, 02, 15),
                    CreationDate = DateTime.Now,
                    IsCompleted = false,
                    IsDeleted = false
                });
        }
    }
}
