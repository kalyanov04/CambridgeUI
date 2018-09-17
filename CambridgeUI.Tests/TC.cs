using CambraidgeUI.Pageobjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CambridgeUI.Tests
{
    [TestFixture]
    class TC:BaseTest
    {
        [Test]
        public void Test()
        {
            MainPage mainPageInstance = new MainPage(webDriver);
            wait.Until(Header.IsDisplayed);
            mainPageInstance.FooterInstance.SocialMediaLinks[5].Click();
        }
    }
}
