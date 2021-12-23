using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace ATM {
   public class Client {
      [Key]
      public int IdClient { get; private set; }
      public string Name { get; set; }
      public string Surname { get; set; }
      public string Address { get; set; }
      public DateTime DateOfBirth { get; set; }
      public CurrentAccount CurrentAccount { get; set; }
      public SavingsAccount SavingsAccount { get; set; }

   }
}