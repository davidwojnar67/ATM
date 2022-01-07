using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace ATM {
   public class TransactionHistoryView {
      public int Id {internal get; set; }
      public int IdAccount {get; set; }
      public string Type { get; set; }
      [Column(TypeName = "decimal(18, 4)")]
      public decimal Amount { get; set; }
      public DateTime Date { get; set; }
      public string Note { get; set; }
      public string Note_For_Recipient { get; set; }
      public int? Variable_Number { get; set; }
      public int? From_Account { get; set; }
      public int? To_Account { get; set; }
   }
}