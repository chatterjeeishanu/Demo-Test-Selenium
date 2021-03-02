using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2.Utilities;
using OpenQA.Selenium;

namespace ClassLibrary2.Test
{
    class DemotestA
    {
        [SetUp]
        public static void StartTest()
        {
            BrowserManagement.LaunchBrowser(TestData.BrowserInput.browser);
        }
        [Test]
        public static void VerifyLaunchURL()
        {
            IWebDriver driver = BrowserManagement.driver;
            Assert.AreEqual(driver.Title, "Google");
        }
        [Test]
        public static void SearchSelenium()
        {
            IWebDriver driver = BrowserManagement.driver;
            driver.FindElement(By.XPath("//input[@title='Search']")).SendKeys("Selenium" + Keys.Enter);
            Assert.AreEqual(driver.Title, "Selenium - Google Search");
        }
        [TearDown]
        public static void CloseTest()
        {
            BrowserManagement.CloseBrowser();
        }
    }
}
