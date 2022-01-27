using RestSharp;
using System;
using System.Configuration;
using System.Text.Json;
using System.Windows.Forms;

namespace AtmUI
{
    public class CreateAccMethods
    {
        public int CreateClient(string name, string surname, string address, DateTimePicker dateOfBirth, decimal currentAccountBalance,
           decimal savingsAccountBalance, double monthlyInterest, string username, string pinCode)
        {

            RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/CreateClient") { };

            Client client = new()
            {
                Name = name,
                Surname = surname,
                Address = address,
                DateOfBirth = dateOfBirth.Value.Date,
                CurrentAccount = new CurrentAccount(currentAccountBalance),
                SavingsAccount = new SavingsAccount((float)monthlyInterest, savingsAccountBalance),
                Username = username,
                PinCodeHash = pinCode
            };

            string body = JsonSerializer.Serialize(client);

            RestRequest restRequest = new(Method.POST);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = restClient.Post(restRequest);

            return ((int)response.StatusCode);
        }


        public double MonthlyInterest()
        {
            RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/MonthlyInterest") { };
            RestRequest restRequest = new(Method.GET);
            var response = restClient.Execute(restRequest);

            return double.Parse(response.Content.Replace(".",","));
        }

    }
}