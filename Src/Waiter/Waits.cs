using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MT_automation.Src.Waiter
{
    public class Waits
    {
        public void WaitForPageLoad(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
