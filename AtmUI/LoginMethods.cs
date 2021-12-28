using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
