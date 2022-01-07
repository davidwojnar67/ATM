using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM {
   public interface IAtmModel {

      /// <summary>
      /// Vrátí klienta dle id
      /// </summary>
      /// <returns></returns>
      Client Client(int Id);

      /// <summary>
      /// Vrátí klienta dle username
      /// </summary>
      /// <param name="Username"></param>
      /// <returns></returns>
      Client Client(string Username);

      /// <summary>
      /// Vytvoøí nového klienta
      /// </summary>
      /// <param name="client"></param>
      /// <returns></returns>
      Task<Client> CreateClient(Client client);

      /// <summary>
      /// Vrátí historii transakcí daného úètu
      /// </summary>
      /// <param name="IdAccount"></param>
      /// <returns></returns>
      Task<List<TransactionHistoryView>> TransactionHistory(int IdAccount);

      /// <summary>
      /// Vložení penìz na úèet
      /// </summary>
      /// <param name="IdClient"></param>
      /// <param name="amount"></param>
      /// <returns></returns>
      Task<CurrentAccount> InsertMoney(int IdAccount, decimal amount);

      /// <summary>
      /// Výbìr penìz z úètu
      /// </summary>
      /// <param name="IdClient"></param>
      /// <param name="amount"></param>
      /// <returns></returns>
      Task<CurrentAccount> WithdrawMoney(int IdAccount, decimal amount);

      /// <summary>
      /// Odeslání penìz na jiný úèet
      /// </summary>
      /// <param name="IdAccount"></param>
      /// <param name="IdRecipientAccount"></param>
      /// <param name="amount"></param>
      /// <returns></returns>
      Task<CurrentAccount> SendMoney(int IdAccount, int IdRecipientAccount, decimal amount, int? variableNumber, string note, string noteForRecipient);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="username"></param>
      /// <param name="pin"></param>
      /// <returns></returns>
      bool Authenticate(string username, string pinCode);

   }
}