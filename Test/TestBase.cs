using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_automation.Test
{
    public abstract class TestBase
    {
        protected static IWebDriver driver;

        [OneTimeSetUp]
        public virtual void BeforeAll()
        {
            //configuration
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

        }
    }
}
