using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM {
   public class AtmModel : IAtmModel {

      private readonly MyDbContext _myDbContext;

      public AtmModel(MyDbContext myDbContext) {
         _myDbContext = myDbContext;
      }

      public async Task<List<Client>> Client(int Id) {
         var foundClient = await _myDbContext.Clients.Where(x => x.IdClient == Id).ToListAsync();

         return foundClient;
      }

      public async Task<Client> CreateClient(Client client) {
         client.PinCodeHash = BCrypt.Net.BCrypt.HashPassword(client.PinCodeHash);
         _myDbContext.Clients.Add(client);
         await _myDbContext.SaveChangesAsync();
         _myDbContext.TransactionHistory.Add(new Transaction(client.CurrentAccount.IdAccount, client.CurrentAccount.Balance, 1, null, null, null, "Deposit when opening a current account", null));
         _myDbContext.TransactionHistory.Add(new Transaction(client.SavingsAccount.IdAccount, client.SavingsAccount.Balance, 1, null, null, null, "Deposit when opening a savings account", null));
         await _myDbContext.SaveChangesAsync();

         return client;
      }

      public async Task<List<Transaction>> TransactionHistory(int IdAccount) {
         var transactionHistory = await _myDbContext.TransactionHistory.Where(x => x.IdAccount == IdAccount).ToListAsync();

         return transactionHistory;
      }

      public async Task<CurrentAccount> InsertMoney(int IdAccount, decimal amount) {
         if (amount > 0) {
            _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount).Balance += amount;
            _myDbContext.TransactionHistory.Add(new Transaction(IdAccount, amount, 1, null, null, null, null, null));
            await _myDbContext.SaveChangesAsync();

            return _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount);
         }
         return null;
      }

      public async Task<CurrentAccount> WithdrawMoney(int IdAccount, decimal amount) {
         if (_myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount).Balance >= amount && amount > 0) {
            _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount).Balance -= amount;
            _myDbContext.TransactionHistory.Add(new Transaction(IdAccount, -amount, 2, null, null, null, null, null));
            await _myDbContext.SaveChangesAsync();

            return _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount);
         }
         return null;
      }

      public async Task<CurrentAccount> SendMoney(int IdAccount, int IdRecipientAccount, decimal amount, int? variableNumber, string note, string noteForRecipient) {
         if (_myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount).Balance >= amount) {
            _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount).Balance -= amount;
            _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdRecipientAccount).Balance += amount;
            Transaction firstTransaction = new(IdAccount, -amount, 3, null, IdRecipientAccount, variableNumber, note, noteForRecipient);
            Transaction secondTransaction = new(IdRecipientAccount, amount, 4, IdAccount, null, variableNumber, noteForRecipient, null);
            _myDbContext.TransactionHistory.AddRange(firstTransaction, secondTransaction);
            await _myDbContext.SaveChangesAsync();

            return _myDbContext.Accounts.FirstOrDefault(x => x.IdAccount == IdAccount);
         }
         return null;
      }

      public bool Authenticate(string username, string pinCode) {
         var account = _myDbContext.Clients.FirstOrDefault(x => x.Username == username);

         if (account == null || !BCrypt.Net.BCrypt.Verify(pinCode, account.PinCodeHash)) {
            return false;
         }
         else {
            return true;
         }
      }

   }

}