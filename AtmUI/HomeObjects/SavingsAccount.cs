namespace AtmUI
{
    public class SavingsAccount : CurrentAccount
    {
        public float InterestPerMensem { get; set; }

        public SavingsAccount(float interestPerMensem, decimal balance) : base(balance)
        {
            InterestPerMensem = interestPerMensem;
        }

    }
}
//tohle nep�ed�l�vat
//klidn� zkusit p�ed�lat