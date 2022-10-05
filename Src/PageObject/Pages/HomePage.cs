using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using MT_automation.Src.Actions;

namespace MT_automation.Src.PageObject.Pages
{
    class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        String home_url = "https://mt-test.ahad.sa/App/TenantDashboard";


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h3.kt-subheader__title")]
        [CacheLookup]
        private IWebElement dashboard_title;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(home_url);
        }

        public String GetPageTitle()
        {
            return driver.Title;
        }

        public string GetHeaderTitle()
        {
            Waits.WaitUntilElementDisplayed(driver, dashboard_title);
            return dashboard_title.Text;
        }
    }
}
