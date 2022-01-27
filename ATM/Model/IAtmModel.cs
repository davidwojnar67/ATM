using System.Collections.Generic;
using System.Threading.Tasks;

namespace ATM
{
    public interface IAtmModel
    {

        /// <summary>
        /// Vyhled�n� klienta dle ID.
        /// </summary>
        /// <param name="Id">ID klienta, kter�ho hled�me.</param>
        /// <returns>Client</returns>
        Client Client(int Id);

        /// <summary>
        /// Vyhled�n� klienta dle Username
        /// </summary>
        /// <param name="Username">Username klienta, kter�ho hled�me.</param>
        /// <returns>Client</returns>
        Client Client(string Username);

        /// <summary>
        /// Vytvo�en� nov�ho klienta.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        Task<Client> CreateClientAsync(Client client);

        /// <summary>
        /// Vyhled�n� transak�n� historie dle Id ��tu.
        /// </summary>
        /// <param name="IdAccount"></param>
        /// <returns></returns>
        Task<List<TransactionView>> TransactionHistoryAsync(int IdAccount);

        /// <summary>
        /// Vlo�en� pen�z na ��et.
        /// </summary>
        /// <param name="IdAccount"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        Task<CurrentAccount> InsertMoneyAsync(int IdAccount, decimal amount);

        /// <summary>
        /// V�b�r pen�z z ��tu.
        /// </summary>
        /// <param name="IdAccount"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        Task<CurrentAccount> WithdrawMoney(int IdAccount, decimal amount);
               
        /// /// <summary>
        /// Odesl�n� pen�z.
        /// </summary>
        /// <param name="IdAccount">Id ��tu z kter�ho jsou pen�ze odes�lan�.</param>
        /// <param name="IdRecipientAccount">Id ��tu na kter� jsou pen�ze zas�lan�.</param>
        /// <param name="amount">��stka.</param>
        /// <param name="variableNumber">Variabiln� ��slo.</param>
        /// <param name="note">Pozn�mka, kterou vid� jenom odes�latel.</param>
        /// <param name="noteForRecipient">Pozn�mka pro p��jemce, zobraz� se p��jemci ve sloupci Note.</param>
        /// <returns></returns>
        Task<CurrentAccount> SendMoney(int IdAccount, int IdRecipientAccount, decimal amount, int? variableNumber, string note, string noteForRecipient);

        /// <summary>
        /// Autentifikace pro p�ihl�en�.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pinCode"></param>
        /// <returns></returns>
        bool Authenticate(string username, string pinCode);

        /// <summary>
        /// Vr�t� m�s��n� �rok.
        /// </summary>
        /// <returns></returns>
        float MonthlyInterest();

    }
}