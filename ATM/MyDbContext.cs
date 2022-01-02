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


      protected override void OnModelCreating(ModelBuilder modelBuilder) {
         modelBuilder.Entity<Cdl_Movement>().HasData(
            new Cdl_Movement { Id = 1, Typ = "Deposit" },
            new Cdl_Movement { Id = 2, Typ = "Withdraw" },
            new Cdl_Movement { Id = 3, Typ = "Outgoing Payment" },
            new Cdl_Movement { Id = 4, Typ = "Incoming payment" }
            );
      }

   }
}
