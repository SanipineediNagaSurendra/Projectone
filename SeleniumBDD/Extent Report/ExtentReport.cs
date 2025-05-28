using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBDD.Extent_Report
{
    public class ExtentReport
    {
        public static ExtentReports _extent;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;
        

        private static string projectpath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private static string resultfolder = Path.Combine(projectpath, "Automation Result");
        private static string _timestamp;
        private static string _uniqueTestResult;

        public static void InitializeReport()
        {
           _timestamp =  DateTime.Now.ToString("yyyy-MM-dd, HH-MM-ss");
           _uniqueTestResult = Path.Combine(resultfolder, _timestamp);

            if(Directory.Exists(_uniqueTestResult))
            {
                Directory.CreateDirectory(_uniqueTestResult);
            }


            var htmlreporter = new ExtentSparkReporter(Path.Combine(_uniqueTestResult, $"{_timestamp}_TestReport.html"));
            htmlreporter.Config.DocumentTitle = "AutomationTestReport";
            htmlreporter.Config.Theme = Theme.Dark;

            _extent = new ExtentReports();
            _extent.AttachReporter(htmlreporter);
           
        }

        

        public static void TearDownReport()
        {
            if(_extent != null)
            {
                _extent.Flush();
            }
        }

        public static string AddScreenShot(IWebDriver driver, ScenarioContext scenariocontext)
        {
           ITakesScreenshot takescreenshot = (ITakesScreenshot)driver;
            Screenshot getscreenshot = takescreenshot.GetScreenshot();

            string  screenshotpath = Path.Combine(_uniqueTestResult, $"{scenariocontext.ScenarioInfo.Title}.png");
            getscreenshot.SaveAsFile(screenshotpath);
            return screenshotpath;

        }
    }
}
