//Nominální úroková míra mùže být stanovena roènì (z lat. per annum – p.a.), pololetnì (per semestre – p.s.),
//ètvrtletnì (per quartale – p.q.), mìsíènì (per mensem – p.m.) a také dennì (per diem – p.d.).

namespace ATM
{
    public class SavingsAccount : CurrentAccount
    {
        public float InterestPerMensem { get; set; }

    }
}