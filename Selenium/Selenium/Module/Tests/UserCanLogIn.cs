using NUnit.Framework;
using Selenium.Module.Utility;

namespace Selenium.Module.Tests
{
    
    public class UserCanLogIn : TestAsALoggedUserBase
    {
        [Test]
        public void LogInTest()
        {
            Pages.Login.LogIn();
            Assert.IsTrue(Pages.Login.IsAt());
                
        }
    }
}
