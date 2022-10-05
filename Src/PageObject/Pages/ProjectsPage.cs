using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace MT_automation.Src.PageObject.Pages
{
    class ProjectsPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        String projects_url = "https://mt-test.ahad.sa/App/Projects";


        public ProjectsPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(projects_url);
        }
    }
}
