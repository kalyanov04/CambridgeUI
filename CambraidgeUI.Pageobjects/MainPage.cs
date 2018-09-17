using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace CambraidgeUI.Pageobjects
{
    public class MainPage
    {
        private IWebDriver webDriver;
        private WebDriverWait wait;

        public Header HeaderInstance { get => new Header(webDriver); }
        public Footer FooterInstance { get => new Footer(webDriver); }

        public MainPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            wait = new WebDriverWait(this.webDriver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(webDriver, this);
        }
    }
}
