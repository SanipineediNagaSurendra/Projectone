using AppiumPraticeNewApp.Drivers;
using AppiumPraticeNewApp.Report;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin;
using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace AppiumPraticeNewApp.Hooks
{
    [Binding]
    public class HooksFeature : ExtentReport
    {
        private AppiumDriver<AndroidElement> _driver { get; set; }
        private static AppiumLocalService _service;
        private ScenarioContext _scenariocontext;
        public HooksFeature(AppiumDriver<AndroidElement>driver, ScenarioContext scenariocontext)
        {
            _driver = driver;
            _scenariocontext = scenariocontext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentReport.InitializeReport();
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtentReport.TearDownReport();
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext _featurecontext)
        {
           _feature =  _extent.CreateTest<Feature>(_featurecontext.FeatureInfo.Title);
        }
        [BeforeScenario]
        public void LaunchTheApp()
        {

            _scenario = _feature.CreateNode<Scenario>(_scenariocontext.ScenarioInfo.Title);
            try
            {
                if (_service == null)
                {
                    StartAppiumserver();

                }
                else
                {
                    Console.WriteLine("sever is already running...");
                }
                var options = new AppiumOptions();
                options.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                options.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
                options.AddAdditionalCapability(MobileCapabilityType.DeviceName, "vivo 1820");
                options.AddAdditionalCapability("appPackage", "com.android.bbkmusic");
                options.AddAdditionalCapability("appActivity", "com.android.bbkmusic.WidgetToTrackActivity");
                options.AddAdditionalCapability("ignoreHiddenApiPolicyError", "true");
                options.AddAdditionalCapability("noReset", true);
                AppiumDriver<AndroidElement> d1 = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), options);
                _driver = d1;

                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            }
            catch (Exception ex) 
            {
                throw new Exception( ex.ToString());
            }
            
        }
        [AfterScenario]
        public void CloseTheApp()
        {
            _driver.Quit();
            StopAppiumServer();
        }
        [AfterStep]
        public void AfterStep()
        {
            string steptype = _scenariocontext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = _scenariocontext.StepContext.StepInfo.Text;

            if(_scenariocontext.TestError == null)
            {
                _scenario.CreateNode(new GherkinKeyword(steptype), stepName);
            }
            else
            {
                string screenshot = AddScreenShot(_driver, _scenariocontext);

                _scenario.CreateNode(new GherkinKeyword(steptype), stepName).Fail(_scenariocontext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(screenshot).Build());
            }
        }

        private static void StartAppiumserver()
        {
           var _service = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                .UsingPort(4723)
                .UsingDriverExecutable(new FileInfo(@"C:\Program Files\nodejs\node.exe"))
                .WithAppiumJS(new FileInfo(@"C:\Users\nagas\AppData\Roaming\npm\node_modules\appium\build\lib\main.js"))
                .WithStartUpTimeOut(TimeSpan.FromSeconds(2))
                .Build();
            _service .Start();
        }
        private static void StopAppiumServer()
        {
            if (_service != null && _service.IsRunning)
            {
                _service.Dispose();
            }
        }
    }
    

}
