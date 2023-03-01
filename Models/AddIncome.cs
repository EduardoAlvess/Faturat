﻿namespace TCC.Models
{
    public class AddIncome : Income
    {
        public List<Category> Categories { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
