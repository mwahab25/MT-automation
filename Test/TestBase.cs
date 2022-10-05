using System;
using MT_automation.Src;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MT_automation.Test
{
    public abstract class TestBase
    {
        protected static IWebDriver driver;

        [OneTimeSetUp]
        public virtual void BeforeAll()
        {
            Log.SetLogger(@".\log.txt");
            ExtentReport.SetExtentReporter(@".\Report" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
        }

        [SetUp]
        public virtual void BeforeEach()
        {      
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mt-test.ahad.sa");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        public virtual void AfterEach()
        {
            var outcome = TestContext.CurrentContext.Result.Outcome.Status;
            
            if(outcome == TestStatus.Passed)
            {

            }
            else
            {

            }

            driver.Close();
        }

        [OneTimeTearDown]
        public virtual void AfterAll()
        {
            ExtentReport.Flush();
            driver.Quit();
            driver.Dispose();
        }
    }
}
