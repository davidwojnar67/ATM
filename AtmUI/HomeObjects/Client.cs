using System;
using System.ComponentModel.DataAnnotations;

namespace AtmUI {
   public class Client {
      [Key]
      public int IdClient { get; private set; }
      public string Name { get; set; }
      public string Surname { get; set; }
      public string Address { get; set; }
      public DateTime DateOfBirth { get; set; }
      public CurrentAccount CurrentAccount { get; set; }
      public SavingsAccount SavingsAccount { get; set; }
      // O�et�en� unik�tn�ho username je v MyDbContext.
      public string Username { get; set; }
      public string PinCodeHash { get; set; }

      public Client(string name, string surname, string address, DateTime dateOfBirth, CurrentAccount currentAccount, SavingsAccount savingsAccount, string username, string pinCodeHash) {
         Name = name;
         Surname = surname;
         Address = address;
         DateOfBirth = dateOfBirth;
         CurrentAccount = currentAccount;
         SavingsAccount = savingsAccount;
         Username = username;
         PinCodeHash = pinCodeHash;
      }
   }
}