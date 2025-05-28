using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace TestMultiplePlugins.Utilities
{
    public class ExtentReport
    {
        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        public static String dir = AppDomain.CurrentDomain.BaseDirectory;
        public static String testResultPath = Path.Combine(dir.Replace("bin\\Debug\\net6.0", "TestResults"), DateTime.Now.ToString("yyyyMMdd_HH_mm_ss"));

        public static void ExtentReportInit()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HH_mm_ss");
            string uniqueTestResultPath = Path.Combine(testResultPath, timestamp);
            // Ensure the directory exists
            Directory.CreateDirectory(uniqueTestResultPath);
            var htmlReporter = new ExtentHtmlReporter(uniqueTestResultPath);
            htmlReporter.Config.ReportName = "Automation Status Report";
            htmlReporter.Config.DocumentTitle = "Automation Status Report";
            htmlReporter.Config.Theme = Theme.Standard;
            htmlReporter.Start();
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(htmlReporter);
            _extentReports.AddSystemInfo("Application", "TestMultiplePlugins.apk");
            _extentReports.AddSystemInfo("OS", "Android 12");
        }
        public static void ExtentReportTearDown()
        {
            _extentReports.Flush();
        }
        public string addScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotLocation = Path.Combine(testResultPath, scenarioContext.ScenarioInfo.Title + ".png");
            screenshot.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);
            return screenshotLocation;
        }
    }
}
