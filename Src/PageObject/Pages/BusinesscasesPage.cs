using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace MT_automation.Src.PageObject.Pages
{
    class BusinesscasesPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        String businesscasess_url = "https://mt-test.ahad.sa/App/BusinessCases";


        public BusinesscasesPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(businesscasess_url);
        }
    }
}
