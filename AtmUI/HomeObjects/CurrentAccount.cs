using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmUI {
   public class CurrentAccount  {
      [Key]
      public int IdAccount { get; private set; }
      [Column(TypeName = "decimal(18, 4)")]
      public decimal Balance { get; set; }

      public CurrentAccount(decimal balance) {
         Balance = balance;
      }
   }
}