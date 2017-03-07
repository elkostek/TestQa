using System;
using NUnit.Framework;
using Selenium.Module.Utility;
using Selenium.Module.Utility.PageObject;

namespace Selenium.Module.Tests
{
    //[TestFixture("Admin")]
    //[TestFixture("SA")]
    public class RunTestClass1 : TestAsALoggedUserBase
    {

        //[Test]

        //public void SomeTest()
        //{
        //    RunTest1();
        //    RunTest2();
        //}

        [Test]
        public void RunTest1()
        {
            Pages.Main.ClickMainTabBooks();
            Pages.Main.ClickMainTabEbooks();
        }
        
        //[Test]
        //public void RunTest2()
        //{
        //    Pages.Main.ClickMainTabBooks();
        //    Pages.Main.ClickMainTabEbooks();
        //}
    }
}
