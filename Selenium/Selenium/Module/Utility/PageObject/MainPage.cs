using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Utility;

namespace Selenium.Module.Utility.PageObject
{
   public class MainPage
    {

        public void ClickMainTabBooks()
        {

            Browser.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.XPath("//a[@title='książki']"))));
            var booksField = Browser.Driver.FindElement(By.XPath("//a[@title='książki']"));
            booksField.Click();
        }

        public void ClickMainTabEbooks()
        {

            Browser.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.XPath("//a[@title='ebooki']"))));
            var ebooksField = Browser.Driver.FindElement(By.XPath("//a[@title='ebooki']"));
            ebooksField.Click();
        }
    }
}
