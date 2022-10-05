using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace MT_automation.Src.PageObject.Pages
{
    class PlansPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        String plans_url = "https://mt-test.ahad.sa/App/PlansLevel";


        public PlansPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }
        public void GoToPage()
        {
            driver.Navigate().GoToUrl(plans_url);
        }
    }
}
