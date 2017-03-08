
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Module.Utility.PageObject;
using Selenium.Utility;

namespace Selenium.Module.Utility
{
    public static class Pages
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }
        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static LogOutPage LogOut
        {
            get { return GetPage<LogOutPage>(); }
        }

        public static MainPage Main
        {
            get { return GetPage<MainPage>(); }
        }
    }
}
