using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary2.Utilities
{
    class BrowserManagement
    {
        public static IWebDriver driver = Global.CoreDriver.driver;
        public static void LaunchBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
            }

            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            
        }
        public static void CloseBrowser()
        {
            driver.Close();
        }
    }
}
