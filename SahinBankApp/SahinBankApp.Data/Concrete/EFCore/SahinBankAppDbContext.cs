using System;
using Microsoft.EntityFrameworkCore;
using SahinBankApp.Entity;

namespace SahinBankApp.Data.Concrete.EFCore
{
	public class SahinBankAppDbContext:DbContext
	{
        public DbSet<ActionMove>? Actions { get; set; }
        public DbSet<ActionType>? ActionTypes { get; set; }
        public DbSet<Invoice>? Invoices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SahinBankApp");
        }

    }
}

