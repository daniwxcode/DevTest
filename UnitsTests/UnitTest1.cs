using System.Threading.Tasks;
using DevTest.Api;
using DevTest.Model;
using DevTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace UnitsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public  void MustResturnTokenNotNull ()
        {
            var  token = DevTest.Api.Server.GetToken();
            Assert.IsNotNull(token);
        }
       
        [TestMethod]
        public void ApiMustRespondWithSuccess ()
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", new Client().ToString(),
             ParameterType.RequestBody);
            var rep = new RestClient(Constants.tokenUrl).Execute(request);
            Assert.IsTrue(rep.StatusCode == System.Net.HttpStatusCode.OK);
        }
        [TestMethod]
        public void ApiGetEmployeesMustSucced0 ()
        {
             // get token 
            var token = DevTest.Api.Server.GetToken();
            // Getting list of Employees
            var request = new RestRequest(Method.GET);
           
            request.AddHeader("access_token", $"{token.Result.AccessToken}");
            var rep = new RestClient(Constants.EmployeesUrl).Execute(request);
            Assert.IsTrue(rep.StatusCode == System.Net.HttpStatusCode.OK);

        }
    }
}
