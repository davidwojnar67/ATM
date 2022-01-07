using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace ATM {
   public class TransactionView {
      public int Id {internal get; set; }
      public int IdAccount {get; set; }
      public string Type { get; set; }
      [Column(TypeName = "decimal(18, 4)")]
      public decimal Amount { get; set; }
      public DateTime Date { get; set; }
      public string Note { get; set; }
      public string NoteForRecipient { get; set; }
      public int? VariableNumber { get; set; }
      public int? FromAccId { get; set; }
      public int? ToAccId { get; set; }
   }
}