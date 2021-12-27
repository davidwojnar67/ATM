using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmUI {
   public class LoginMethods {

      public bool Login(string Username, string PinCode) {

         RestClient restClient = new("https://localhost:5001/Authenticate") { };

         RestRequest restRequest = new(Method.GET);
         restRequest.AddParameter("username", Username);
         restRequest.AddParameter("pinCode", PinCode);

         var response = restClient.Execute(restRequest);

         return Convert.ToBoolean(response.Content);
      }

   }
}
