using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace MT_automation.Src.PageObject.Pages
{
    class MeiPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        String mei_url = "https://mt-test.ahad.sa/App/Metrics?isMei=true";


        public MeiPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(mei_url);
        }
    }
}
