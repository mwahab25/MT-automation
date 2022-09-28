using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace MT_automation.Src.PageObject.Pages
{
    class LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "usernameOrEmailAddress")]
        [CacheLookup]
        private IWebElement username_text;

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        private IWebElement password_text;

        [FindsBy(How = How.Id, Using = "kt_login_signin_submit")]
        [CacheLookup]
        private IWebElement login_text;

        public void Login(string username,string pass)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(username_text));
            username_text.SendKeys(username);

            wait.Until(ExpectedConditions.ElementToBeClickable(password_text));
            password_text.SendKeys(pass);
            
            wait.Until(ExpectedConditions.ElementToBeClickable(login_text));
            login_text.Click();
        }
    }
}
