using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using MT_automation.Src.Actions;

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
            Waits.WaitUntilElementDisplayed(driver,username_text);
            Elements.Type(username_text,username);

            Waits.WaitUntilElementDisplayed(driver, password_text);
            Elements.Type(password_text, pass);

            Waits.WaitUntilElementToBeClickable(driver, login_text);
            Elements.Click(login_text);
        }
    }
}
