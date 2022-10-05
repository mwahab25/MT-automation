using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MT_automation.Src.Actions
{
    public static class Waits
    {
        private static WebDriverWait wait;

        private static void WaitFluent(IWebDriver driver, double? timeout = null)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout ?? Config.Timeout))
            { PollingInterval = TimeSpan.FromMilliseconds(500) };

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException), typeof(StaleElementReferenceException));
        }

        private static void WaitExplict(IWebDriver driver, double? timeout = null)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout ?? Config.Timeout));
           
        }

        public static void WaitUntilElementToBeClickable(IWebDriver driver, IWebElement locator, double? timeout = null)
        {
            WaitExplict(driver, timeout);
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
        public static void WaitUntilElementDisplayed(IWebDriver driver, IWebElement locator, double? timeout = null)
        {
            WaitExplict(driver, timeout);
            wait.Until(driver=> locator.Displayed);
        }
    }
}
