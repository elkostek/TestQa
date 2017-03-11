using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Utility
{
 

    public static class Browser
    {
        
        private static IWebDriver _webDriver;
        private static string _baseUrl = "https://www.empik.com/";
        private static WebDriverWait _wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(20));


        public static ISearchContext Driver { get { return _webDriver; } }
        public static WebDriverWait Wait { get { return _wait; } }
        //public static string Title { get { return _webDriver.Title; } }


        public static void Initialize()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Navigate().GoToUrl(_baseUrl);
           // GoTo("");

        }
        public static void Close()
        {
            _webDriver.Close();
        }
        public static void Quit()
        {
            _webDriver.Quit();
        }
        //public static void GoTo(string url, bool userBaseUrl = true)
        //{
        //    if (userBaseUrl)
        //        _webDriver.Navigate().GoToUrl(string.Format("{0}/{1}", _baseUrl, url));
        //    else
        //        _webDriver.Navigate().GoToUrl(url);

        //}
    }
}
