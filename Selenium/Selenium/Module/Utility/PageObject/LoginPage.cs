using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Utility;

namespace Selenium.Module.Utility.PageObject
{

    public class LoginPage
    {
        private string userName = "marcin@kosek.waw.pl";
        private string password = "qwerty12#";

        public void LogIn()
        {
            Browser.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.XPath("//a[@class='firstNotLogged']"))));
            var logIn = Browser.Driver.FindElement(By.XPath("//a[@class='firstNotLogged']"));
            logIn.Click();
            Browser.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.Id("email"))));
            var userNameField = Browser.Driver.FindElement(By.Id("email"));
            userNameField.SendKeys(userName);
            var passwordField = Browser.Driver.FindElement(By.Id("password"));
            passwordField.SendKeys(password);
            var clickButton = Browser.Driver.FindElement(By.XPath("//a[contains(text(),'Zaloguj się')]"));
            clickButton.Click();
            
        }

        public bool IsAt()
        {
            Browser.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.XPath("//a[@class='first'] //*[contains(text(),'testAdmin')]"))));
            return Browser.Driver.FindElement(By.XPath("//a[@class='first'] //*[contains(text(),'testAdmin')]")).Displayed;

        }
    }
}
