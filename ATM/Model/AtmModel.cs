using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace ATM
{
    public class AtmModel : IAtmModel
    {

        private readonly MyDbContext _myDbContext;

        public AtmModel(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public Client Client(int Id)
        {
            var foundClient = _myDbContext.Clients.Where(x => x.IdClient == Id).Include(x => x.CurrentAccount).Include(x => x.SavingsAccount).First();

            return foundClient;
        }

        public Client Client(string Username)
        {
            var foundClient = _myDbContext.Clients.Where(x => x.Username == Username).Include(x => x.CurrentAccount).Include(x => x.SavingsAccount).First();

            return foundClient;
        }

        public async Task<Client> CreateClientAsync(Client client)
        {
            if (client.CurrentAccount.Balance < 0 || client.SavingsAccount.Balance < 0 || client.Address == "" || client.Name == "" || client.Surname == "" || client.Username == "" || client.PinCodeHash == "")
            {
                throw new ArgumentNullException();
            }
                        
            try
            {
                // Použití transakce, buï probìhnou všechny SaveChangesAsync, anebo žáden.
                using var transaction = _myDbContext.Database.BeginTransaction();
                client.PinCodeHash = BCrypt.Net.BCrypt.HashPassword(client.PinCodeHash);
                _myDbContext.Clients.Add(client);
                // Jsou použity dva SaveChangesAsync, jinak bychom neznali clientovo ID a nemohli bychom vytvoøit záznamy v TransactionHistory.
                try
                {
                    await _myDbContext.SaveChangesAsync();
                }
                // Odchytavání vyjímky duplicitního username.
                catch (Microsoft.EntityFrameworkCore.DbUpdateException)
                {
                    throw new ArgumentException(ConfigurationManager.AppSettings["DuplicateUsernameException"]);
                }
                _myDbContext.TransactionHistory.Add(new Transaction(client.CurrentAccount.IdAccount, client.CurrentAccount.Balance, 1, null, null, null, "Deposit when opening a current account", null));
                _myDbContext.TransactionHistory.Add(new Transaction(client.SavingsAccount.IdAccount, client.SavingsAccount.Balance, 1, null, null, null, "Deposit when opening a savings account", null));
                await _myDbContext.SaveChangesAsync();
                transaction.Commit();
            }
            catch (Exception)
            {
                throw;
            }            

            return client;
        }

        public async Task<List<TransactionView>> TransactionHistoryAsync(int IdAccount)
        {
            var transactionHistory = await _myDbContext.TransactionHistoryView.Where(x => x.IdAccount == IdAccount).ToListAsync();

            return transactionHistory;
        }

        public async Task<CurrentAccount> InsertMoneyAsync(int IdAccount, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(ConfigurationManager.AppSettings["InsertMoneyException"]);
            }

            _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount).Balance += amount;
            _myDbContext.TransactionHistory.Add(new Transaction(IdAccount, amount, 1, null, null, null, null, null));
            await _myDbContext.SaveChangesAsync();

            return _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount);
        }

        public async Task<CurrentAccount> WithdrawMoney(int IdAccount, decimal amount)
        {
            if (_myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount).Balance < amount || amount < 0)
            {
                throw new ArgumentException(ConfigurationManager.AppSettings["WithdrawMoneyException"]);
            }

            _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount).Balance -= amount;
            _myDbContext.TransactionHistory.Add(new Transaction(IdAccount, -amount, 2, null, null, null, null, null));
            await _myDbContext.SaveChangesAsync();

            return _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount);
        }

        public async Task<CurrentAccount> SendMoney(int IdAccount, int IdRecipientAccount, decimal amount, int? variableNumber, string note, string noteForRecipient)
        {
            if (_myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount).Balance < amount)
            {
                throw new ArgumentException(ConfigurationManager.AppSettings["SendMoneyBalanceException"]);
            }
            else if (_myDbContext.Accounts.Find(IdRecipientAccount) == null)
            {
                throw new ArgumentException(ConfigurationManager.AppSettings["SendMoneyRecipientException"]);
            }

            _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount).Balance -= amount;
            _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdRecipientAccount).Balance += amount;
            Transaction firstTransaction = new(IdAccount, -amount, 3, null, IdRecipientAccount, variableNumber, note, noteForRecipient);
            Transaction secondTransaction = new(IdRecipientAccount, amount, 4, IdAccount, null, variableNumber, noteForRecipient, null);
            _myDbContext.TransactionHistory.AddRange(firstTransaction, secondTransaction);
            await _myDbContext.SaveChangesAsync();

            return _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount);

        }

        public bool Authenticate(string username, string pinCode)
        {
            var account = _myDbContext.Clients.FirstOrDefault(x => x.Username == username);

            if (account == null || !BCrypt.Net.BCrypt.Verify(pinCode, account.PinCodeHash))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public float MonthlyInterest()
        {
            Random random = new();
            return (random.Next(200, 300)) / 100.0f;
        }

    }

}