using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace MT_automation.Src.PageObject.Pages
{
    class InitiativePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        String initiative_url = "https://mt-test.ahad.sa/App/InitiativeLevel";


        public InitiativePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(initiative_url);
        }
    }
}
