using CambraidgeUI.Pageobjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CambridgeUI.Tests
{
    [TestFixture]
    class Test_CountSocialLinks:BaseTest
    {
        [Test]
        public void Test()
        {
            MainPage mainPageInstance = new MainPage(webDriver);
            wait.Until(Header.IsDisplayed);
            Assert.AreEqual(7, mainPageInstance.FooterInstance.SocialMediaLinks.Count);
        }
    }
}
