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
                    CreationDate = DateTime.Now,
                    isDeleted = false
                },
                new Account
                {
                    Id = 2,
                    UserId = 2,
                    IconId = 2,
                    Name = "Conta PJ",
                    Balance = 233.33,
                    CreationDate = DateTime.Now,
                    isDeleted = false
                });
        }

        private static void SeedCategories(ModelBuilder builder)
        {
            builder.Entity<ExpenseCategory>().HasData(
                new ExpenseCategory
                {
                    Id = 1,
                    IconId = 1,
                    Description = "Gym",
                    CreationDate = DateTime.Now
                },
                new ExpenseCategory
                {
                    Id = 2,
                    IconId = 2,
                    Description = "Clothing",
                    CreationDate = DateTime.Now
                },
                new IncomeCategory
                {
                    Id = 3,
                    IconId = 3,
                    Description = "Education",
                    CreationDate = DateTime.Now
                },
                new IncomeCategory
                {
                    Id = 4,
                    IconId = 4,
                    Description = "Pet",
                    CreationDate = DateTime.Now
                },
                new IncomeCategory
                {
                    Id = 5,
                    IconId = 5,
                    Description = "Electronics",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 6,
                    IconId = 6,
                    Description = "Health",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 7,
                    IconId = 7,
                    Description = "Home",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 8,
                    IconId = 8,
                    Description = "Taxes",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 9,
                    IconId = 9,
                    Description = "Leisure",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 10,
                    IconId = 10,
                    Description = "Others",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 11,
                    IconId = 11,
                    Description = "Restaurant",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 12,
                    IconId = 12,
                    Description = "Services",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 13,
                    IconId = 13,
                    Description = "Supermarket",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 14,
                    IconId = 14,
                    Description = "Transportation",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 15,
                    IconId = 15,
                    Description = "Travel",
                    CreationDate = DateTime.Now
                }); 
            builder.Entity<IncomeCategory>().HasData(
                new IncomeCategory
                {
                    Id = 16,
                    IconId = 16,
                    Description = "Awards",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 17,
                    IconId = 17,
                    Description = "Gift",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 18,
                    IconId = 18,
                    Description = "Investments",
                    CreationDate = DateTime.Now
                }, 
                new IncomeCategory
                {
                    Id = 19,
                    IconId = 19,
                    Description = "Salary",
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
                    CreationDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                    Category = CategoryType.Supermarket
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
                    CreationDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                    Category = CategoryType.Restaurant
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
                    CreationDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                    Category = CategoryType.Salary
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
                    CreationDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                    Category = CategoryType.Awards
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
                    CreationDate = DateTime.Now,
                    IsDeleted = false
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
                    CreationDate = DateTime.Now,
                    IsDeleted = false
                });
        }
    }
}
