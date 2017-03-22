
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
       
        //[ClassInitialize]
        [TestFixtureSetUp]
        public static void Initialize()
        { 

            Browser.Initialize();
            Pages.Login.LogIn();

        }

        [TestFixtureTearDown]
        //[TearDown]
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
