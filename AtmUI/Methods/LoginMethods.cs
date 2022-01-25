using RestSharp;
using System;
using System.Configuration;

namespace AtmUI {
   public class LoginMethods {

      public bool Login(string username, string pinCode) {

         RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/Authenticate") { };

         RestRequest restRequest = new(Method.GET);
         restRequest.AddParameter("username", username);
         restRequest.AddParameter("pinCode", pinCode);

         var response = restClient.Execute(restRequest);

         return Convert.ToBoolean(response.Content);
      }

   }
}
