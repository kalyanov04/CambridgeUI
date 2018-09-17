using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace CambraidgeUI.Pageobjects
{
    public class Header
    {
        private IWebDriver webDriver;
        private WebDriverWait wait;

        public Header(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            wait = new WebDriverWait(this.webDriver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(webDriver, this);
        }
        [FindsBy(How = How.XPath, Using = HeaderPaths.Logo)]
        public IWebElement Logo { get; set; }

        [FindsBy(How = How.XPath, Using = HeaderPaths.StudyAtCambridgeButton)]
        public IWebElement StudyAtCambridgeButton { get; set; }

        [FindsBy(How = How.XPath, Using = HeaderPaths.AboutTheUniversityButton)]
        public IWebElement AboutTheUniversityButton { get; set; }

        [FindsBy(How = How.XPath,Using =HeaderPaths.ResearchAtCambridgeButton)]
        public IWebElement ResearchAtCambridgeButton { get; set; }

        [FindsBy(How = How.XPath, Using = HeaderPaths.GiveToCambridgeButton)]
        public IWebElement GiveToCambridgeButton { get; set; }

        [FindsBy(How = How.XPath, Using = HeaderPaths.Quicklinks)]
        public IWebElement Quicklinks { get; set; }

        [FindsBy(How = How.XPath, Using = HeaderPaths.SearchBox)]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.XPath, Using = HeaderPaths.SearchButton)]
        public IWebElement SearchButton { get; set; }

        public static bool IsDisplayedWithLogo(IWebDriver webDriver)
        {
            try
            {
                if (webDriver.FindElement(By.XPath(HeaderPaths.StudyAtCambridgeButton)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.Logo)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.AboutTheUniversityButton)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.ResearchAtCambridgeButton)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.Quicklinks)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.SearchBox)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.SearchButton)).Displayed) return true;
                else return false;
            }
            catch (NoSuchElementException) { return false; }
            catch (StaleElementReferenceException) { return false; }
        }
        public static bool IsDisplayed(IWebDriver webDriver)
        {
            try
            {
                if (webDriver.FindElement(By.XPath(HeaderPaths.StudyAtCambridgeButton)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.AboutTheUniversityButton)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.ResearchAtCambridgeButton)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.GiveToCambridgeButton)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.SearchBox)).Displayed &
                    webDriver.FindElement(By.XPath(HeaderPaths.SearchButton)).Displayed) return true;
                else return false;
            }
            catch (NoSuchElementException) { return false; }
            catch (StaleElementReferenceException) { return false; }
        }
    }
}
