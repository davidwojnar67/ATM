using RestSharp;
using System;
using System.Configuration;

namespace AtmUI
{
    public class LoginMethods
    {
        public enum LoginStatus
        {
            Success,
            LoginFailed,
            InvalidConnection
        }

        public LoginStatus Login(string username, string pinCode)
        {
            RestClient restClient = new(ConfigurationManager.AppSettings["URL"] + "/Authenticate") { };

            RestRequest restRequest = new(Method.GET);
            restRequest.AddParameter("username", username);
            restRequest.AddParameter("pinCode", pinCode);

            var response = restClient.Execute(restRequest);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (Convert.ToBoolean(response.Content))
                {
                    return LoginStatus.Success;
                }
                else
                {
                    return LoginStatus.LoginFailed;
                }
            }
            else
            {
                return LoginStatus.InvalidConnection;
            }

        }

    }
}
