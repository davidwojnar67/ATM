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
//tohle nepøedìlávat
//klidnì zkusit pøedìlat