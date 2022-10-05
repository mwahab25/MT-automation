using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace MT_automation.Src.PageObject.Pages
{
    class ChangeRequestsPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        String cr_url = "https://mt-test.ahad.sa/App/ChangeRequests";


        public ChangeRequestsPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(cr_url);
        }
    }
}
