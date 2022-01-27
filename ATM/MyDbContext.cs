using Microsoft.EntityFrameworkCore;

namespace ATM
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Transaction> TransactionHistory { get; set; }
        // SavingsAccount se automatick� taky vlo�� do tabulky Accounts.
        public DbSet<CurrentAccount> Accounts { get; set; }
        public DbSet<Cdl_Movement> Cdl_Movements { get; set; }
        public DbSet<TransactionView> TransactionHistoryView { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Napln�n� tabulky Cdl_Movement p�i prvn� migraci.
            modelBuilder.Entity<Cdl_Movement>().HasData(
               new Cdl_Movement { Id = 1, Type = "Deposit" },
               new Cdl_Movement { Id = 2, Type = "Withdraw" },
               new Cdl_Movement { Id = 3, Type = "Outgoing Payment" },
               new Cdl_Movement { Id = 4, Type = "Incoming Payment" }
               );

            // Vytvo�en� view, kter� se pou��v� p�i zobrazen� historie ��tu. + Je pot�eba vytvo�it migraci, viz. p�ilo�en� n�vod (TransactionHistoryView.txt).
            modelBuilder.Entity<TransactionView>().ToView(nameof(TransactionHistoryView)).HasKey(t => t.Id);

            // Klientovo username mus� b�t unik�tn�. Pokud ne, vrac� se status: 500.
            modelBuilder.Entity<Client>().HasIndex(x => x.Username).IsUnique();
        }

    }
}
