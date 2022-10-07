using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TCC.Models;

namespace TCC.Db
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Icon> Icons { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Transaction>().HasDiscriminator<string>("Type");
            builder.Entity<Income>(entity => { entity.HasBaseType<Transaction>(); });
            builder.Entity<Expense>(entity => { entity.HasBaseType<Transaction>(); });

            builder.Entity<Category>().HasDiscriminator<string>("Type");
            builder.Entity<ExpenseCategory>(entity => { entity.HasBaseType<Category>(); });
            builder.Entity<IncomeCategory>(entity => { entity.HasBaseType<Category>(); });

            DbSeeder.SeedTables(builder);
        }
    }
}
