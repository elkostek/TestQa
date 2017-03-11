
using NUnit.Framework;
using Selenium.Module.Utility;
using Selenium.Utility;

namespace Selenium.Module.Tests
{
   
    public class TestAsALoggedUserBase
    {
        //public TestAsALoggedUserBase()
        //{
        //     Browser.Initialize();
        //     Pages.Login.LogIn();
        //}


        [SetUp]
        //[ClassInitialize]
        //[TestFixtureSetUp]
        public void Initialize()
        { 
            //Browser browser = new Browser();
            //browser.Initialize();
            Browser.Initialize();
            // Pages.Login.LogIn();
            //_webDriver.Navigate().GoToUrl(_baseUrl);
        }

        //[TestFixtureTearDown]
        [TearDown]
        public void Cleanup()
        {
            Browser.Close();
            Browser.Quit();
        }

        //[TearDown]
        //public void Cleanup()
        //{
        //    Browser.Close();
        //    Browser.Quit();
        //}


    }

}
