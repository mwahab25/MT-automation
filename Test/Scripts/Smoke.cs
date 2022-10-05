using System;
using NUnit.Framework;
using MT_automation.Src.PageObject.Pages;
using MT_automation.Src;

namespace MT_automation.Test.Scripts
{
	[TestFixture]
	[Parallelizable]
	public class Smoke : TestBase
	{
		[Test]
		public void Login()
		{
			ExtentReport.CreateTest("Login", "Login to system");

			Log.Info("Begin Login Test case");
			ExtentReport.Info("Begin Login Test case");

			LoginPage login_page = new LoginPage(driver);
			login_page.Login("Admin", "123qwe");

			HomePage home_page = new HomePage(driver);
			home_page.GetHeaderTitle();
			try
			{
				Assert.AreEqual(driver.Url, "https://mt-test.ahad.sa/App/TenantDashboard");
				
				Log.Info("Finish Login Test case");
				ExtentReport.Info("Finish Login Test case");
				Log.Pass("Test Pass");
				ExtentReport.Pass("Test Pass");
			}
			catch
            {
				Log.Info("Finish Login Test case");
				ExtentReport.Info("Finish Login Test case");
				Log.Fail("Test Fail");
				ExtentReport.Fail("Test Fail");
			}
			
		}
	}
}
