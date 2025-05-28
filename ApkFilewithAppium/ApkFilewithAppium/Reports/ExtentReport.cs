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

namespace ApkFilewithAppium.Reports
{
    public class ExtentReport
    {
       
        public static ExtentReports _extent;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        //get the project path

        private static string projectpath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        //Folder exsist inside the Project

        private static string resultpath = Path.Combine(projectpath, "AutomationReport");

        private static string _timestamp;
        private static string _testresultpath;

        public static void InitializeReport()
        {
            _timestamp = DateTime.Now.ToString("yyyy-MM-dd, HH-mm-ss");
            _testresultpath = Path.Combine(resultpath, _timestamp);

            if(Directory.Exists(_testresultpath))
            {
                Directory.CreateDirectory(_testresultpath);
            }

            var htmlreporter = new ExtentSparkReporter(Path.Combine(_testresultpath, $"{_timestamp}_TestReport.html"));
            htmlreporter.Config.DocumentTitle = "Automation Result";
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

        public static string  AddScreenShot(AppiumDriver<AndroidElement> driver, ScenarioContext scenariocontext)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            

            string screenshotpath = Path.Combine(_testresultpath, $"{scenariocontext.ScenarioInfo.Title}.png");
            screenshot.SaveAsFile(screenshotpath,ScreenshotImageFormat.Png);
            return screenshotpath;

        }
    }
}
