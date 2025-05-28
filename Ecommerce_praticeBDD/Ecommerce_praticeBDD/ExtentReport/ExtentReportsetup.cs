using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_praticeBDD.ExtentReport
{
    public class ExtentReportsetup
    {
        public static ExtentReports extent;
        public static ExtentTest feature;
        public static ExtentTest Scenario;

        public static string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExtentReport");
         

        public static void InitializeReport()
        {
            string timestamp = DateTime.Now.ToString("yyyy_MM_dd _HH_mm_ss");
            string uniqueTestResultPath = Path.Combine(dir, timestamp);

            // Ensure the directory exists
            Directory.CreateDirectory(uniqueTestResultPath);
            var htmlreporter = new ExtentSparkReporter(uniqueTestResultPath + $"\\{timestamp}_TestReport.html");
            htmlreporter.Config.DocumentTitle = "Automation Status Title";

            htmlreporter.Config.Theme = Theme.Dark;

            extent = new ExtentReports();
            extent.AttachReporter(htmlreporter);
        }
        public static void TearDownReport()
        {
            extent.Flush();
        }
        public  string AddScreenShot(AppiumDriver<AndroidElement>driver, ScenarioContext scenariocontext)
        {
            ITakesScreenshot screenshot = (ITakesScreenshot)driver;
            Screenshot pic = screenshot.GetScreenshot();
            string screenshotLocation = Path.Combine(dir, scenariocontext.ScenarioInfo.Title + ".Png");
            pic.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);
            return screenshotLocation;
        }
    }
    
}
