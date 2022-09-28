using MT_automation.Src.PageObject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace MT_automation.Test.Scripts
{
	[TestFixture]
	[Parallelizable]
	public class Smoke : TestBase
	{
		[Test]
		public void Login()
		{
			LoginPage login_page = new LoginPage(driver);
			login_page.Login("Admin", "123qwe");

			HomePage home_page = new HomePage(driver);
			home_page.getHeaderTitle();

			Console.WriteLine(driver.Url);
			Assert.AreEqual(driver.Url, "https://mt-test.ahad.sa/App/TenantDashboard");
		}
	}
}
