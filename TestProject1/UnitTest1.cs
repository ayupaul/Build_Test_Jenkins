using Build_Test_Jenkins.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        HomeController controller=new HomeController();
        [TestMethod]
        public void IndexTest()
        {
            var results=controller.Index() as ViewResult;
            Assert.AreEqual("Index", results?.ViewName);
        }
        [TestMethod]
        public void PrivacyTest()
        {
            var results=controller.Privacy() as ViewResult;
            Assert.AreEqual("Privacy",results?.ViewName);
        }
    }
}