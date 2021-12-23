using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ATM {
   public class MyDbContext : DbContext {
      public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

      public DbSet<Client> Clients { get; set; }
      public DbSet<Transaction> TransactionHistory { get; set; }
      public DbSet<CurrentAccount> Accounts { get; set; }
      public DbSet<Cdl_Movement> Cdl_Movements { get; set; }
      //public DbSet<SavingsAccount> SavingsAccounts { get; set; }


      protected override void OnModelCreating(ModelBuilder modelBuilder) {
         modelBuilder.Entity<Cdl_Movement>().HasData(
            new Cdl_Movement { Id = 1, Typ = "Vklad" },
            new Cdl_Movement { Id = 2, Typ = "Výbìr" },
            new Cdl_Movement { Id = 3, Typ = "Odchozí platba" },
            new Cdl_Movement { Id = 4, Typ = "Pøíchozí platba" }
            );
      }
   }
}
