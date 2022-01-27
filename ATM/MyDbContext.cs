using Microsoft.EntityFrameworkCore;

namespace ATM
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Transaction> TransactionHistory { get; set; }
        // SavingsAccount se automatický taky vloží do tabulky Accounts.
        public DbSet<CurrentAccount> Accounts { get; set; }
        public DbSet<Cdl_Movement> Cdl_Movements { get; set; }
        public DbSet<TransactionView> TransactionHistoryView { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Naplnìní tabulky Cdl_Movement pøi první migraci.
            modelBuilder.Entity<Cdl_Movement>().HasData(
               new Cdl_Movement { Id = 1, Type = "Deposit" },
               new Cdl_Movement { Id = 2, Type = "Withdraw" },
               new Cdl_Movement { Id = 3, Type = "Outgoing Payment" },
               new Cdl_Movement { Id = 4, Type = "Incoming Payment" }
               );

            // Vytvoøení view, které se používá pøi zobrazení historie úètu. + Je potøeba vytvoøit migraci, viz. pøiložený návod (TransactionHistoryView.txt).
            modelBuilder.Entity<TransactionView>().ToView(nameof(TransactionHistoryView)).HasKey(t => t.Id);

            // Klientovo username musí být unikátní. Pokud ne, vrací se status: 500.
            modelBuilder.Entity<Client>().HasIndex(x => x.Username).IsUnique();
        }

    }
}
