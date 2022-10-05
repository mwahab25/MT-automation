using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace MT_automation.Src.PageObject.Pages
{
    class TasksPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        String tasks_url = "https://mt-test.ahad.sa/App/Tasks/Ticket";


        public TasksPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(tasks_url);
        }
    }
}
