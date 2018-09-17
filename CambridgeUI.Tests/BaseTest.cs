using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace CambridgeUI.Tests
{
    [TestFixture]
    class BaseTest
    {
        protected IWebDriver webDriver;
        private static string baseURL = ConfigurationManager.AppSettings["url"];
        private static string browser = ConfigurationManager.AppSettings["browser"];
        protected WebDriverWait wait;

        [OneTimeSetUp]
        public void BeforeTest()
        {
            switch (browser)
            {
                case "Chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments("start-maximized");
                    webDriver = new ChromeDriver(chromeOptions);
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    webDriver.Manage().Window.Maximize();
                    break;
            }
            webDriver.Url = baseURL;
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
        [OneTimeTearDown]
        public void AftrTest()
        {
            webDriver.Quit();
        }      
    }
}
