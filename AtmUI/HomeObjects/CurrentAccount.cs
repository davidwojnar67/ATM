using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmUI
{
    public class CurrentAccount
    {
        public int IdAccount { get; private set; }
        public decimal Balance { get; set; }

        public CurrentAccount(decimal balance)
        {
            Balance = balance;
        }
    }
}