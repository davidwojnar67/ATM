using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATM {
   public class MyDbContext : DbContext {
      public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

      public DbSet<Client> Clients { get; set; }
      public DbSet<Transaction> TransactionHistory { get; set; }
      public DbSet<CurrentAccount> Accounts { get; set; }
      public DbSet<Cdl_Movement> Cdl_Movements { get; set; }
      //public DbSet<SavingsAccount> Accounts { get; set; }
      public DbSet<TransactionHistoryView> TransactionHistoryView { get; set; }


      protected override void OnModelCreating(ModelBuilder modelBuilder) {
         modelBuilder.Entity<Cdl_Movement>().HasData(
            new Cdl_Movement { Id = 1, Type = "Deposit" },
            new Cdl_Movement { Id = 2, Type = "Withdraw" },
            new Cdl_Movement { Id = 3, Type = "Outgoing Payment" },
            new Cdl_Movement { Id = 4, Type = "Incoming payment" }
            );
         modelBuilder.Entity<TransactionHistoryView>().ToView(nameof(TransactionHistoryView)).HasKey(t => t.Id);

      }

   }
}
