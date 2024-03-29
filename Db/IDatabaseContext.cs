﻿using Microsoft.EntityFrameworkCore;
using TCC.Areas.Identity.Data;
using TCC.Models;

namespace TCC.Db
{
    public interface IDatabaseContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Transaction> Transactions { get; set; }
        DbSet<Goal> Goals { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Account> Accounts { get; set; }
        void SaveChanges(Object item, string state);
    }
}
