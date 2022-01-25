using RestSharp;
using System;
using System.Configuration;
using System.Text.Json;
using System.Windows.Forms;

namespace AtmUI {
   public class CreateAccMethods {

      public double RandomMonthlyInterest() {
         Random random = new();
         return Convert.ToDouble(random.Next(200, 300)) / 100;
      }

      public int CreateClient(string name, string surname, string address, DateTimePicker dateOfBirth, decimal currentAccountBalance,
         decimal savingsAccountBalance, double monthlyInterest, string username, string pinCode) {

         RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/CreateClient") { };

         Client client = new Client(name, surname, address, dateOfBirth.Value.Date, new CurrentAccount(currentAccountBalance), new SavingsAccount((float)monthlyInterest, savingsAccountBalance), username, pinCode);

         string body = JsonSerializer.Serialize(client);

         RestRequest restRequest = new(Method.POST);
         restRequest.AddHeader("Content-Type", "application/json");
         restRequest.AddParameter("application/json", body, ParameterType.RequestBody);

         var response = restClient.Post(restRequest);

         return ((int)response.StatusCode);
      }


   }
}