using System.Collections.Generic;
using System.Threading.Tasks;

namespace ATM
{
    public interface IAtmModel
    {

        /// <summary>
        /// Vyhledání klienta dle ID.
        /// </summary>
        /// <param name="Id">ID klienta, kterého hledáme.</param>
        /// <returns>Client</returns>
        Client Client(int Id);

        /// <summary>
        /// Vyhledání klienta dle Username
        /// </summary>
        /// <param name="Username">Username klienta, kterého hledáme.</param>
        /// <returns>Client</returns>
        Client Client(string Username);

        /// <summary>
        /// Vytvoøení nového klienta.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        Task<Client> CreateClientAsync(Client client);

        /// <summary>
        /// Vyhledání transakèní historie dle Id úètu.
        /// </summary>
        /// <param name="IdAccount"></param>
        /// <returns></returns>
        Task<List<TransactionView>> TransactionHistoryAsync(int IdAccount);

        /// <summary>
        /// Vložení penìz na úèet.
        /// </summary>
        /// <param name="IdAccount"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        Task<CurrentAccount> InsertMoneyAsync(int IdAccount, decimal amount);

        /// <summary>
        /// Výbìr penìz z úètu.
        /// </summary>
        /// <param name="IdAccount"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        Task<CurrentAccount> WithdrawMoney(int IdAccount, decimal amount);
               
        /// /// <summary>
        /// Odeslání penìz.
        /// </summary>
        /// <param name="IdAccount">Id úètu z kterého jsou peníze odesílaný.</param>
        /// <param name="IdRecipientAccount">Id úètu na který jsou peníze zasílaný.</param>
        /// <param name="amount">Èástka.</param>
        /// <param name="variableNumber">Variabilní èíslo.</param>
        /// <param name="note">Poznámka, kterou vidí jenom odesílatel.</param>
        /// <param name="noteForRecipient">Poznámka pro pøíjemce, zobrazí se pøíjemci ve sloupci Note.</param>
        /// <returns></returns>
        Task<CurrentAccount> SendMoney(int IdAccount, int IdRecipientAccount, decimal amount, int? variableNumber, string note, string noteForRecipient);

        /// <summary>
        /// Autentifikace pro pøihlášení.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pinCode"></param>
        /// <returns></returns>
        bool Authenticate(string username, string pinCode);

        /// <summary>
        /// Vrátí mìsíèní úrok.
        /// </summary>
        /// <returns></returns>
        float MonthlyInterest();

    }
}