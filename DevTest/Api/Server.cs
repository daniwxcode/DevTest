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
                // get token 
                Token token = await GetToken();
                //display Token
                Console.WriteLine(token.AccessToken);
              }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
