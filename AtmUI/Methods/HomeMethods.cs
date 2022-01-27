using RestSharp;
using System;
using System.Configuration;

namespace AtmUI
{
    public class HomeMethods
    {
        private string LoggedUsername;
        private string errorMessage;

        public HomeMethods()
        {
            LoggedUsername = GlobalSettings.Username;
        }

        public string ClientByUsername()
        {
            RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/ClientByUsername") { };
            RestRequest restRequest = new(Method.GET);
            restRequest.AddParameter("Username", LoggedUsername);
            var response = restClient.Execute(restRequest);

            return response.Content;
        }

        public string TransactionHistory(int idAccount)
        {
            RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/TransactionHistory") { };
            RestRequest restRequest = new(Method.GET);
            restRequest.AddParameter("IdAccount", idAccount);
            var response = restClient.Execute(restRequest);

            return response.Content;
        }

        public bool InsertMoney(int idAccount, decimal amount)
        {
            RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/InsertMoney");
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddQueryParameter("IdAccount", idAccount.ToString());
            restRequest.AddQueryParameter("amount", amount.ToString().Replace(",", "."));
            var response = restClient.Post(restRequest);

            int r = (int)response.StatusCode;

            if (r == 200)
            {
                return true;
            }
            errorMessage = response.Content;
            return false;
        }

        public bool WithdrawMoney(int idAccount, decimal amount)
        {
            RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/WithdrawMoney");
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddQueryParameter("IdAccount", idAccount.ToString());
            restRequest.AddQueryParameter("amount", amount.ToString().Replace(",", "."));
            var response = restClient.Post(restRequest);

            int r = (int)response.StatusCode;

            if (r == 200)
            {
                return true;
            }
            errorMessage = response.Content;
            return false;
        }

        public int SendMoney(int IdAccount, int IdRecipientAccount, decimal amount, int? variableNumber, string note, string noteForRecipient)
        {
            RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/SendMoney");

            var restRequest = new RestRequest(Method.POST);

            restRequest.AddQueryParameter("IdAccount", IdAccount.ToString());
            restRequest.AddQueryParameter("IdRecipientAccount", IdRecipientAccount.ToString());
            restRequest.AddQueryParameter("amount", amount.ToString().Replace(",", "."));
            restRequest.AddQueryParameter("variableNumber", variableNumber.ToString());
            restRequest.AddQueryParameter("note", note);
            restRequest.AddQueryParameter("noteForRecipient", noteForRecipient);

            var response = restClient.Post(restRequest);

            return ((int)response.StatusCode);
        }

        public string GetErrorMessage()
        {
            return errorMessage.Substring(1, errorMessage.Length - 2);
        }
    }
}