using DevTest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void MustRetunExactlyAnApiResponse ()
        {
            var token = DevTest.Api.Server.GetToken();
            Assert.AreEqual(token.GetType(),typeof(Token));
        }
    }
}
