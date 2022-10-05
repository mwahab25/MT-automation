using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace MT_automation.Src
{
    public class ExtentReport
    {
        private static ExtentReports extent;
        private static ExtentTest testcase;

        public static void SetExtentReporter(string reportpath)
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(reportpath);
            htmlReporter.Config.Theme = Theme.Standard;
            extent.AttachReporter(htmlReporter);
        }

        public static void Flush()
        {
            extent.Flush();
        }

        internal static void CreateTest(String sTestCaseTitle, String sTestCaseDesc)
        {
            testcase = extent.CreateTest(sTestCaseTitle, sTestCaseDesc);
        }

        internal static void StartTestCase(String sTestCaseName)
        {
            testcase.Info("Start TestCase " + sTestCaseName);
        }

        internal static void EndTestCase(String sTestCaseName)
        {
            testcase.Info("End TestCase " + sTestCaseName);
        }

        internal static void Log(Status status,String message)
        {
            testcase.Log(status, message);
        }

        internal static void Info(String message)
        {
            testcase.Info(message);
        }

        internal static void Pass(String message)
        {
            testcase.Pass(message);
        }

        internal static void Fail(String message)
        {
            testcase.Fail(message);
        }

        internal static void Error(String message)
        {
            testcase.Error(message);
        }

        internal static void Warn(String message)
        {
            testcase.Warning(message);
        }

        internal static void AddScreenShot(String path)
        {
            testcase.AddScreenCaptureFromPath(path);
        }
    }
}