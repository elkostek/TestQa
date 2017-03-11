using System;
using NUnit.Framework;
using Selenium.Module.Utility;
using Selenium.Module.Utility.PageObject;

namespace Selenium.Module.Tests
{
    //[TestFixture("Admin")]
    //[TestFixture("SA")]
    public class RunTestClass2 : TestAsALoggedUserBase
    {

        [Test]
        public void RunTest2()
        {

            Pages.Main.ClickMainTabBooks();
            Pages.Main.ClickMainTabEbooks();
        }
    }
}
