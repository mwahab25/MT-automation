using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_automation.Src.Actions
{
    class Elements
    {
        public static void Click(IWebElement element)
        {
            Log.Info($"Click on element {element.Text}");
            ExtentReport.Info($"Click on element {element.Text}");
            element.Click();
        }

        public static void Type(IWebElement element, string text)
        {
            Log.Info($"Type {text} on element {element.Text}");
            ExtentReport.Info($"Type {text} on element {element.Text}");
            element.SendKeys(text);
        }
    }
}
