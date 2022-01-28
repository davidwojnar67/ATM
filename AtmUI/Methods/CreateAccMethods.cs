using RestSharp;
using System;
using System.Configuration;
using System.Text.Json;
using System.Windows.Forms;

namespace AtmUI
{
    public class CreateAccMethods
    {
        private string errorMessage;

        public enum CreateStatus
        {
            Ok,
            Failed,
            UserAlreadyExists
        }

        public CreateStatus CreateClient(string name, string surname, string address, DateTimePicker dateOfBirth, decimal currentAccountBalance, decimal savingsAccountBalance, float monthlyInterest, string username, string pinCode)
        {

            RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/CreateClientAsync") { };

            Client client = new()
            {
                Name = name,
                Surname = surname,
                Address = address,
                DateOfBirth = dateOfBirth.Value.Date,
                CurrentAccount = new CurrentAccount()
                {
                    Balance = currentAccountBalance
                },
                SavingsAccount = new SavingsAccount()
                {
                    Balance = savingsAccountBalance,
                    InterestPerMensem = monthlyInterest
                },
                Username = username,
                PinCodeHash = pinCode
            };

            string body = JsonSerializer.Serialize(client);

            RestRequest restRequest = new(Method.POST);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = restClient.Post(restRequest);
            int r = (int)response.StatusCode;

            if (r == 200)
            {
                return CreateStatus.Ok;
            }
            errorMessage = response.Content;
            return r == 400 ? CreateStatus.UserAlreadyExists : CreateStatus.Failed;
        }


        public float MonthlyInterest()
        {
            RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/MonthlyInterest") { };
            RestRequest restRequest = new(Method.GET);
            var response = restClient.Execute(restRequest);

            return float.Parse(response.Content.Replace(".", ","));
        }

        public string GetErrorMessage()
        {
            return errorMessage.Substring(1, errorMessage.Length - 2); //2. varianta: return errorMessage[1..^1];
        }

    }
}