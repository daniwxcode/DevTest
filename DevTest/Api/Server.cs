using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DevTest.Model;
using DevTest.Settings;
using Newtonsoft.Json;
using RestSharp;

namespace DevTest.Api
{
    public static class Server
    {
        public static async Task<Token> GetToken ()
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", new Client().ToString(),
             ParameterType.RequestBody);
            var rep = await new RestClient(Constants.tokenUrl).ExecuteTaskAsync<ApiTokenResponse>(request);
            return rep.Data.Data;
        }
       


        public static async Task RunAsync ()
        {
            try
            {
                Console.WriteLine("1-getting tokens");
                // get token 
                Token token = await GetToken();
                //display Token
                Console.WriteLine(token.AccessToken);

                // Getting list of Employees
                var request = new RestRequest(Method.GET);
                Console.WriteLine("Getting Employees");
                request.AddHeader("access_token", $"{token.AccessToken}");
                var rep = new RestClient(Constants.EmployeesUrl).Execute(request);

                //Diplaying Results
                new ApiEmployeesResponse().Display(rep.Content);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
