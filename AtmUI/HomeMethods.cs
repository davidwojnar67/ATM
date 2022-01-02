using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AtmUI {
   public class HomeMethods {
      private string LoggedUsername { get; set; }

      public HomeMethods(string loggedUsername) {
         LoggedUsername = loggedUsername;
      }

      public string GetClientByUsername() {
         RestClient restClient = new("https://localhost:5001/ClientByUsername") { };

         RestRequest restRequest = new(Method.GET);
         restRequest.AddParameter("Username", LoggedUsername);

         var response = restClient.Execute(restRequest);

         return response.Content;
      }

      //Napsat tohle korektně
      public string InsertMoney(int idAccount, decimal amount) {

         string url = "https://localhost:5001/InsertMoney?IdAccount=" + idAccount + "&amount=" + amount.ToString().Replace(",",".");

         //string url = "https://localhost:5001/InsertMoney"
         RestClient restClient = new(url);

         var restRequest = new RestRequest(Method.PATCH);

         //restRequest.AddParameter("IdAccount", idAccount, ParameterType.UrlSegment);
         //restRequest.AddParameter("amount", amount, ParameterType.UrlSegment);

         var response = restClient.Execute(restRequest);

         return response.StatusCode.ToString();
      }

      public string WithdrawMoney(int idAccount, decimal amount) {

         string url = "https://localhost:5001/WithdrawMoney?IdAccount=" + idAccount + "&amount=" + amount.ToString().Replace(",", ".");

         RestClient restClient = new(url);

         var restRequest = new RestRequest(Method.PATCH);
         
         var response = restClient.Execute(restRequest);

         return response.StatusCode.ToString();
      }


   }
}
