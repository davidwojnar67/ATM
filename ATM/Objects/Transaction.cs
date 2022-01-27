using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ATM
{
    public class Transaction
    {
        [Key]
        public int IdTranHis { get; private set; }
        public int IdAccount { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int Movement { get; set; }
        public int? FromAccId { get; set; }
        public int? ToAccId { get; set; }
        public int? VariableNumber { get; set; }
        public string Note { get; set; }
        public string NoteForRecipient { get; set; }

        public Transaction(int idAccount, decimal amount, int movement, int? fromAccId, int? toAccId, int? variableNumber, string note, string noteForRecipient)
        {
            IdAccount = idAccount;
            Amount = amount;
            Date = DateTime.Now;
            Movement = movement;
            FromAccId = fromAccId;
            ToAccId = toAccId;
            VariableNumber = variableNumber;
            Note = note;
            NoteForRecipient = noteForRecipient;
        }
    }
}