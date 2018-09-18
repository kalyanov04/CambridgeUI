using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace CambraidgeUI.Pageobjects
{
    public class Footer
    {
        private IWebDriver webDriver;
        private WebDriverWait wait;

        public Footer(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            wait = new WebDriverWait(this.webDriver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(webDriver, this);
        }
        [FindsBy(How = How.ClassName, Using = FooterPaths.SocialMediaLinks)]
        public IList<IWebElement> SocialMediaLinks { get; set; }

        [FindsBy(How = How.XPath, Using = FooterPaths.ConnectButton)]
        public IList<IWebElement> ConnectButton { get; set; }


    }
}
