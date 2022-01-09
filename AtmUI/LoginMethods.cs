using RestSharp;
using System;

namespace AtmUI {
   public class LoginMethods {

      public bool Login(string username, string pinCode) {

         RestClient restClient = new("https://localhost:5001/Authenticate") { };

         RestRequest restRequest = new(Method.GET);
         restRequest.AddParameter("username", username);
         restRequest.AddParameter("pinCode", pinCode);

         var response = restClient.Execute(restRequest);

         return Convert.ToBoolean(response.Content);
      }

   }
}
