using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace test
{
	[TestFixture]
    public class Tests
    {
		private static IWebDriver driver;
        
		[SetUp]
        public void Setup()
        {
			driver =new ChromeDriver();
			driver.Navigate().GoToUrl("https://mt-test.ahad.sa");
			driver.Manage().Window.Maximize();
			driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(30);
		}
		
        [Test]
        public void Login()
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

			wait.Until(ExpectedConditions.ElementIsVisible(By.Name("usernameOrEmailAddress")));
			driver.FindElement(By.Name("usernameOrEmailAddress")).SendKeys("Admin");
			
			wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
			driver.FindElement(By.Name("password")).SendKeys("123qwe");

			wait.Until(ExpectedConditions.ElementIsVisible(By.Id("kt_login_signin_submit")));
			driver.FindElement(By.Id("kt_login_signin_submit")).Click();

			wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("h3.kt-subheader__title")));

			Console.WriteLine(driver.Url);
			Assert.AreEqual(driver.Url, "https://mt-test.ahad.sa/App/TenantDashboard");
		}

		[TearDown]
		public void EndTest()
		{
			driver.Close();
		}

    }

}
