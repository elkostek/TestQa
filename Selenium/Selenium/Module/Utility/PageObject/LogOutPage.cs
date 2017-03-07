using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Utility;


namespace Selenium.Module.Utility.PageObject
{
   public class LogOutPage
    {

        public void LogOut()
        {
            Browser.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.XPath("//i[@class='tc-icon icon-user_2_special']"))));
            var yourProfileField = Browser.Driver.FindElement(By.XPath("//i[@class='tc-icon icon-user_2_special']"));
            yourProfileField.Click();
            Browser.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.XPath("//li[@ng-click='$ctrl.signOut()']"))));
            var signOutField = Browser.Driver.FindElement(By.XPath("//li[@ng-click='$ctrl.signOut()']"));
            signOutField.Click();

        }

        public bool IsAt()
        {
            Browser.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.XPath("//span[@class='logo-lg animated fadeIn']"))));
            return Browser.Driver.FindElement(By.XPath("//span[@class='logo-lg animated fadeIn']")).Displayed;
        }
    }
}
