using Microsoft.EntityFrameworkCore;
using TCC.Models;

namespace TCC.Db
{
    public static class DbSeeder
    {
        public static void SeedTables(ModelBuilder builder)
        {
            SeedUsers(builder);
            SeedIcons(builder);
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
                    Name = "Eduardo",
                    Password = "12345",
                    isDeleted = false,
                    CreationDate = DateTime.Now
                },
                new User
                {
                    Id = 2,
                    Name = "Paulo",
                    Password = "54321",
                    isDeleted = false,
                    CreationDate = DateTime.Now
                });
        }

        private static void SeedIcons(ModelBuilder builder)
        {
            builder.Entity<Icon>().HasData(
                new Icon
                {
                    Id = 1,
                    ImageName = "img1.jpg"
                },
                new Icon
                {
                    Id = 2,
                    ImageName = "img2.jpg"
                });
        }

        private static void SeedAccounts(ModelBuilder builder)
        {
            builder.Entity<Account>().HasData(
                new Account
                {
                    Id = 1,
                    UserId = 1,
                    IconId = 1,
                    Name = "Conta corrente",
                    Balance = 2000,
                    CreationDate = DateTime.Now
                },
                new Account
                {
                    Id = 2,
                    UserId = 2,
                    IconId = 2,
                    Name = "Conta PJ",
                    Balance = 233.33,
                    CreationDate = DateTime.Now
                });
        }

        private static void SeedCategories(ModelBuilder builder)
        {
            builder.Entity<ExpenseCategory>().HasData(
                new ExpenseCategory
                {
                    Id = 1,
                    IconId = 1,
                    Description = "Supermarket",
                    CreationDate = DateTime.Now
                },
                new ExpenseCategory
                {
                    Id = 2,
                    IconId = 2,
                    Description = "Restaurant",
                    CreationDate = DateTime.Now
                });
            builder.Entity<IncomeCategory>().HasData(
                new IncomeCategory
                {
                    Id = 3,
                    IconId = 1,
                    Description = "Salary",
                    CreationDate = DateTime.Now
                },
                new IncomeCategory
                {
                    Id = 4,
                    IconId = 2,
                    Description = "Award",
                    CreationDate = DateTime.Now
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
                    CategoryId = 1,
                    Value = 250,
                    Description = "Mercado",
                    isPaid = true,
                    isDeleted = false,
                    CreationDate = DateTime.Now
                },
                new Expense
                {
                    Id = 2,
                    UserId = 2,
                    AccountId = 2,
                    CategoryId = 2,
                    Value = 172.35,
                    Description = "Alaminuta",
                    isPaid = false,
                    isDeleted = false,
                    CreationDate = DateTime.Now
                });
            builder.Entity<Income>().HasData(
                new Income
                {
                    Id = 3,
                    UserId = 1,
                    AccountId = 1,
                    CategoryId = 3,
                    Value = 2000,
                    Description = "Salário",
                    isReceived = true,
                    isDeleted = false,
                    CreationDate = DateTime.Now
                },
                new Income
                {
                    Id = 4,
                    UserId = 2,
                    AccountId = 2,
                    CategoryId = 4,
                    Value = 13.75,
                    Description = "Premio",
                    isReceived = false,
                    isDeleted = false,
                    CreationDate = DateTime.Now
                });
        }

        private static void SeedGoals(ModelBuilder builder)
        {
            builder.Entity<Goal>().HasData(
                new Goal
                {
                    Id = 1,
                    UserId = 1,
                    IconId = 1,
                    Name = "Viagem",
                    FinalAmount = 2000,
                    CurrentAmount = 400,
                    FinalDate = new DateTime(2023, 01, 15),
                    CreationDate = DateTime.Now
                },
                new Goal
                {
                    Id = 2,
                    UserId = 2,
                    IconId = 2,
                    Name = "Carro",
                    FinalAmount = 35000.72,
                    CurrentAmount = 12000.32,
                    FinalDate = new DateTime(2023, 02, 15),
                    CreationDate = DateTime.Now
                });
        }
    }
}
