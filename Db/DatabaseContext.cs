﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TCC.Areas.Identity.Data;
using TCC.Models;

namespace TCC.Db
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DbSet<IdentityUserClaim<string>> IdentityUserClaim { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }

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

            builder.Entity<IdentityUserClaim<string>>().HasKey(p => new { p.Id });
        }

        public void SaveChanges(Object item, string state)
        {
            if (state.Equals("Added"))
                Entry(item).State = EntityState.Added;
            if (state.Equals("Modified"))
                Entry(item).State = EntityState.Modified;

            SaveChanges();
        }
    }
}
