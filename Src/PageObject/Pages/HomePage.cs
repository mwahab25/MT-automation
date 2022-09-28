using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h3.kt-subheader__title")]
        [CacheLookup]
        private IWebElement dashboard_title;

        public void goToPage()
        {
            driver.Navigate().GoToUrl(home_url);
        }

        public String getPageTitle()
        {
            return driver.Title;
        }

        public string getHeaderTitle()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(dashboard_title));
            return dashboard_title.Text;
        }
    }
}
