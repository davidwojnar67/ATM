using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM
{
    public class CurrentAccount
    {
        [Key]
        public int IdAccount { get; private set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Balance { get; set; }

    }
}