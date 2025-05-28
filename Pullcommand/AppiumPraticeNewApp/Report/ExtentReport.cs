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

namespace AppiumPraticeNewApp.Report
{
    public class ExtentReport
    {
        public static ExtentReports _extent;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        private static string Projectpath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private static string resulthpath = Path.Combine(Projectpath, "AutomationReport");
        private static string _timestamp;
        private static string _testresult;

        public static void InitializeReport()
        {
            _timestamp = DateTime.Now.ToString("yyyy-MM-dd,HH-mm-ss");
            _testresult = Path.Combine(_timestamp, resulthpath);

            if(Directory.Exists == null)
            {
                Directory.CreateDirectory(_testresult);
            }

            var htmlreporter = new ExtentSparkReporter(Path.Combine(_testresult, $"{_timestamp}_TestReport.html"));
            htmlreporter.Config.DocumentTitle = "AutomationReport";
            htmlreporter.Config.Theme = Theme.Dark;
            _extent = new ExtentReports();
            _extent.AttachReporter(htmlreporter);
        }

        public static void TearDownReport() 
        {
            _extent.Flush();
        }

        public static string AddScreenShot(AppiumDriver<AndroidElement>driver, ScenarioContext scenariocontext)
        {
           ITakesScreenshot takescreenshot =  (ITakesScreenshot)driver;
           Screenshot screenshot =  takescreenshot.GetScreenshot();

            string screenshotpath = Path.Combine(_testresult, $"{scenariocontext.ScenarioInfo.Title}.png");
            screenshot.SaveAsFile(screenshotpath, ScreenshotImageFormat.Png);
            return screenshotpath;
        }
    }
}
