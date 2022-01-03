using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmUI {
   public class CreateAccMethods {

      public double RandomMonthlyInterest() {
         Random random = new();
         return Convert.ToDouble(random.Next(200, 300)) / 100;
      }

      public int CreateClient(string name, string surname, string address, DateTimePicker dateOfBirth, decimal currentAccountBalance,
         decimal savingsAccountBalance, double monthlyInterest, string username, string pinCode) {

         RestClient restClient = new("https://localhost:5001/CreateClient") { };

         //UPRAVIT TUHLE "ZHOVADILOST"
         string body =
            "{\"name\":\"" + name + "\"," +
            "\"surname\":\"" + surname + "\"," +
            "\"address\":\"" + address + "\"," +
            "\"DateOfBirth\":\"" + dateOfBirth.Value.Year + "-" + (dateOfBirth.Value.Month < 10 ? "0" + dateOfBirth.Value.Month : dateOfBirth.Value.Month) + "-" + (dateOfBirth.Value.Day < 10 ? "0" + dateOfBirth.Value.Day : dateOfBirth.Value.Day) + "T00:00:00\"," +
            "\"currentAccount\": { \"balance\": " + currentAccountBalance + " }," +
            "\"savingsAccount\": {\"balance\": " + savingsAccountBalance + ", \"interestPerMensem\":  " + monthlyInterest.ToString().Replace(",", ".") + "  }," +
            "\"username\": \"" + username + "\"," +
            "\"pinCodeHash\": \"" + pinCode + "\"}";

         RestRequest restRequest = new(Method.POST);
         restRequest.AddHeader("Content-Type", "application/json");
         restRequest.AddParameter("application/json", body, ParameterType.RequestBody);

         var response = restClient.Execute(restRequest);

         return ((int)response.StatusCode);
      }


   }
}