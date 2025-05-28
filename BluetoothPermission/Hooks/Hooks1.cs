using Reqnroll;

namespace BluetoothPermission.Hooks
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}



//using TechTalk.SpecFlow;
//using OpenQA.Selenium;
//using System;
//using System.IO;
//using OpenQA.Selenium.Appium;
//using OpenQA.Selenium.Appium.Android;
//using BoDi;
//using NUnit.Framework;
//using AventStack.ExtentReports.Reporter;
//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Gherkin.Model;
//using BluetoothPermission.Drivers;

//namespace BluetoothPermission.Hooks
//{
//    [Binding]
//    public class Hooks
//    {
//        private static ExtentReports _extentReports;
//        private static ExtentTest _feature;
//        private static ExtentTest _scenario;
//        private readonly ScenarioContext _scenarioContext;
//        private readonly FeatureContext _featureContext;
//        private readonly TestContext _testContext;
//        private readonly IObjectContainer _container;
//        private string _reportPath;
//        private string _screenshotsDir;

//        public Hooks(
//            ScenarioContext scenarioContext,
//            FeatureContext featureContext,
//            TestContext testContext,
//            IObjectContainer container)
//        {
//            _scenarioContext = scenarioContext;
//            _featureContext = featureContext;
//            _testContext = testContext;
//            _container = container;
//        }

//        [BeforeTestRun]
//        public static void BeforeTestRun()
//        {
//            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
//            string reportDirectory = "C:\\Users\\iray\\source\\repos\\connectingHIsBluetooth\\ExtentReport";
//            Directory.CreateDirectory(reportDirectory);

//            string reportFileName = Path.Combine(reportDirectory, $"Hello_{timestamp}.html");
//            var htmlReporter = new ExtentHtmlReporter(reportFileName);
//            htmlReporter.Config.ReportName = "Automation Status Report";
//            htmlReporter.Config.DocumentTitle = "Automation Status Report";
//            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

//            _extentReports = new ExtentReports();
//            _extentReports.AttachReporter(htmlReporter);
//        }

//        [BeforeFeature]
//        public static void BeforeFeature(FeatureContext featureContext)
//        {
//            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
//        }

//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            _scenario = _feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);

//            // Initialize Android Appium driver
//            var appiumOptions = new AppiumOptions();
//            appiumOptions.AddAdditionalCapability("platformName", "Android");
//            appiumOptions.AddAdditionalCapability("platformVersion", "14");
//            appiumOptions.AddAdditionalCapability("deviceName", "Samsung S23");
//            appiumOptions.AddAdditionalCapability("udid", "RZCWB12C5DN");
//            appiumOptions.AddAdditionalCapability("appPackage", "com.android.settings");
//            appiumOptions.AddAdditionalCapability("appActivity", "com.android.settings.Settings");
//            appiumOptions.AddAdditionalCapability("adbExecTimeout", 50000);

//            var commandExecutor = new OpenQA.Selenium.Appium.Service.HttpCommandExecutor(
//                new Uri("http://localhost:4723/wd/hub"),
//                TimeSpan.FromSeconds(1000)
//            );

//            var driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

//            // Store and register driver
//            drivers.driver1 = driver;
//            _container.RegisterInstanceAs<AppiumDriver<AndroidElement>>(driver);

//            // Setup screenshot directory
//            string scenarioTitleSafe = _scenarioContext.ScenarioInfo.Title.Replace(" ", "_");
//            _screenshotsDir = Path.Combine("Screenshots", scenarioTitleSafe);
//            Directory.CreateDirectory(_screenshotsDir);
//        }

//        [AfterStep]
//        public void AfterStep()
//        {
//            string stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
//            string stepName = _scenarioContext.StepContext.StepInfo.Text;

//            if (_scenarioContext.TestError == null)
//            {
//                if (stepType == "Given")
//                    _scenario.CreateNode<Given>(stepName).Pass("Passed");
//                else if (stepType == "When")
//                    _scenario.CreateNode<When>(stepName).Pass("Passed");
//                else if (stepType == "Then")
//                    _scenario.CreateNode<Then>(stepName).Pass("Passed");
//                else
//                    _scenario.CreateNode<And>(stepName).Pass("Passed");
//            }
//            else
//            {
//                // Take screenshot if there's an error
//                try
//                {
//                    var screenshot = ((ITakesScreenshot)_testContext.AndroidDriver).GetScreenshot();
//                    string screenshotPath = Path.Combine(_screenshotsDir, $"{Guid.NewGuid()}.png");
//                    screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

//                    if (stepType == "Given")
//                        _scenario.CreateNode<Given>(stepName).Fail(_scenarioContext.TestError.Message)
//                            .AddScreenCaptureFromPath(screenshotPath);
//                    else if (stepType == "When")
//                        _scenario.CreateNode<When>(stepName).Fail(_scenarioContext.TestError.Message)
//                            .AddScreenCaptureFromPath(screenshotPath);
//                    else if (stepType == "Then")
//                        _scenario.CreateNode<Then>(stepName).Fail(_scenarioContext.TestError.Message)
//                            .AddScreenCaptureFromPath(screenshotPath);
//                    else
//                        _scenario.CreateNode<And>(stepName).Fail(_scenarioContext.TestError.Message)
//                            .AddScreenCaptureFromPath(screenshotPath);
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Screenshot failed: {ex.Message}");
//                }
//            }
//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            _testContext.AndroidDriver?.Quit();
//        }

//        [AfterTestRun]
//        public static void AfterTestRun()
//        {
//            _extentReports.Flush();
//        }
//    }
//}




//    public class Hooks
//    {
//        private static ExtentReports _extentReports;
//        private static readonly object _lock = new object();
//        private static ExtentTest _feature;
//        private ExtentTest _scenario;
//        private readonly ScenarioContext _scenarioContext;
//        private readonly FeatureContext _featureContext;
//        private readonly TestContext _testContext;
//        private readonly IObjectContainer _container;
//        private string _reportPath;
//        private string _screenshotsDir;

//        public Hooks(
//            ScenarioContext scenarioContext,
//            FeatureContext featureContext,
//            TestContext testContext,
//            IObjectContainer container)
//        {
//            _scenarioContext = scenarioContext;
//            _featureContext = featureContext;
//            _testContext = testContext;
//            _container = container;
//        }

//        [BeforeTestRun]
//        public static void BeforeTestRun()
//        {
//            lock (_lock)
//            {
//                if (_extentReports == null)
//                {
//                    string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
//                    string reportDirectory = Path.Combine(Environment.CurrentDirectory, "ExtentReports");
//                    Directory.CreateDirectory(reportDirectory);

//                    string reportFileName = Path.Combine(reportDirectory, $"AutomationReport_{timestamp}.html");
//                    var htmlReporter = new ExtentHtmlReporter(reportFileName);
//                    htmlReporter.Config.ReportName = "Automation Status Report";
//                    htmlReporter.Config.DocumentTitle = "Automation Status Report";
//                    htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

//                    _extentReports = new ExtentReports();
//                    _extentReports.AttachReporter(htmlReporter);
//                }
//            }
//        }

//        [BeforeFeature]
//        public static void BeforeFeature(FeatureContext featureContext)
//        {
//            lock (_lock)
//            {
//                _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
//            }
//        }

//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            _scenario = _feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);

//            // Initialize Android Appium driver
//            var appiumOptions = new AppiumOptions();
//            appiumOptions.AddAdditionalCapability("platformName", "Android");
//            appiumOptions.AddAdditionalCapability("platformVersion", "14");
//            appiumOptions.AddAdditionalCapability("deviceName", "Samsung galaxy A54");
//            appiumOptions.AddAdditionalCapability("udid", "RZCWB12C5DN");
//            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray\\source\\TestMultiplePlugins.apk");
//           // appiumOptions.AddAdditionalCapability("appActivity", "com.android.settings.Settings");
//            appiumOptions.AddAdditionalCapability("adbExecTimeout", 50000);

//            var commandExecutor1 = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(1000));


//            var driver = new AndroidDriver<AndroidElement>(commandExecutor1, appiumOptions);
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

//            // Store and register driver
//            drivers.driver1 = driver;
//            _container.RegisterInstanceAs<AppiumDriver<AndroidElement>>(driver);

//            // Setup screenshot directory
//            string scenarioTitleSafe = _scenarioContext.ScenarioInfo.Title.Replace(" ", "_");
//            _screenshotsDir = Path.Combine("Screenshots", scenarioTitleSafe);
//            Directory.CreateDirectory(_screenshotsDir);
//        }

//        [AfterStep]
//        public void AfterStep()
//        {
//            string stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
//            string stepName = _scenarioContext.StepContext.StepInfo.Text;

//            if (_scenarioContext.TestError == null)
//            {
//                if (stepType == "Given")
//                    _scenario.CreateNode<Given>(stepName).Pass("Passed");
//                else if (stepType == "When")
//                    _scenario.CreateNode<When>(stepName).Pass("Passed");
//                else if (stepType == "Then")
//                    _scenario.CreateNode<Then>(stepName).Pass("Passed");
//                else
//                    _scenario.CreateNode<And>(stepName).Pass("Passed");
//            }
//            else
//            {
//                // Take screenshot if there's an error
//                if (drivers.driver1 != null)
//                {
//                    try
//                    {
//                        var screenshot = ((ITakesScreenshot)drivers.driver1).GetScreenshot();
//                        string screenshotPath = Path.Combine(_screenshotsDir, $"{Guid.NewGuid()}.png");
//                        screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

//                        if (stepType == "Given")
//                            _scenario.CreateNode<Given>(stepName).Fail(_scenarioContext.TestError.Message)
//                                .AddScreenCaptureFromPath(screenshotPath);
//                        else if (stepType == "When")
//                            _scenario.CreateNode<When>(stepName).Fail(_scenarioContext.TestError.Message)
//                                .AddScreenCaptureFromPath(screenshotPath);
//                        else if (stepType == "Then")
//                            _scenario.CreateNode<Then>(stepName).Fail(_scenarioContext.TestError.Message)
//                                .AddScreenCaptureFromPath(screenshotPath);
//                        else
//                            _scenario.CreateNode<And>(stepName).Fail(_scenarioContext.TestError.Message)
//                                .AddScreenCaptureFromPath(screenshotPath);
//                    }
//                    catch (Exception ex)
//                    {
//                        Console.WriteLine($"Screenshot failed: {ex.Message}");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Driver instance is null. Screenshot cannot be captured.");
//                }
//            }
//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            if (drivers.driver1 != null)
//            {
//                drivers.driver1.Quit();
//                drivers.driver1.Dispose();
//            }
//        }

//        [AfterTestRun]
//        public static void AfterTestRun()
//        {
//            lock (_lock)
//            {
//                if (_extentReports != null)
//                {
//                    _extentReports.Flush();
//                }
//            }
//        }
//    }


//using OpenQA.Selenium;
//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Gherkin.Model;
//using OpenQA.Selenium.Appium.Windows;
//using Reqnroll;



//namespace BluetoothPermission.Hooks
//{

//    [Binding]
//    public class Hooks
//    {
//        private static ExtentReports _extentReports;
//        private static ExtentTest _feature;
//        private static ExtentTest _scenario;
//        private string textDir;
//        private readonly ScenarioContext _scenarioContext;
//        private readonly FeatureContext _featureContext;
//        private WindowsDriver<WindowsElement> Driver;


//        public Hooks(ScenarioContext scenarioContext, FeatureContext featureContext)
//        {
//            _scenarioContext = scenarioContext;
//            _featureContext = featureContext;
//        }

//        [BeforeTestRun]
//        public static void BeforeTestRun()
//        {
//            // Generate a dynamic file name with a timestamp
//            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
//            string reportDirectory = "C:\\Users\\iray\\source\\repos\\connectingHIsBluetooth\\ExtentReport";
//            Directory.CreateDirectory(reportDirectory); // Ensure the directory exists
//            string reportFileName = Path.Combine(reportDirectory, $"Hello_{timestamp}.html");

//            // Log the report file path for debugging
//            Console.WriteLine($"Report will be saved as: {reportFileName}");

//            // Delete the existing report if it exists
//            if (File.Exists(reportFileName))
//            {
//                File.Delete(reportFileName);
//                Console.WriteLine("Previous report file deleted.");
//            }

//            // Initialize ExtentHtmlReporter
//            var htmlReporter = new ExtentHtmlReporter(reportFileName);

//            // Configure the report
//            htmlReporter.Config.ReportName = "Automation Status Report";
//            htmlReporter.Config.DocumentTitle = "Automation Status Report";
//            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

//            // Attach the reporter to ExtentReports
//            _extentReports = new ExtentReports();
//            _extentReports.AttachReporter(htmlReporter);

//            //Console.WriteLine("ExtentHtmlReporter initialized successfully.");
//        }


//        [BeforeFeature]
//        public static void BeforeFeature(FeatureContext featureContext)
//        {
//            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
//        }

//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            _scenario = _feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
//        }

//        [AfterStep]
//        public void AfterStep(ScenarioContext scenarioContext)
//        {
//            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
//            string stepName = scenarioContext.StepContext.StepInfo.Text;

//            //var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
//            if (_scenarioContext.TestError == null)
//            {
//                if (stepType == "Given")
//                    _scenario.CreateNode<Given>(stepName).Pass(stepName + " passed");
//                else if (stepType == "When")
//                    _scenario.CreateNode<When>(stepName).Pass(stepName + " passed");
//                else if (stepType == "Then")
//                    _scenario.CreateNode<Then>(stepName).Pass(stepName + " passed");
//                else if (stepType == "And")
//                    _scenario.CreateNode<And>(stepName).Pass(stepName + " passed");
//            }
//            else if (_scenarioContext.TestError != null)
//            {
//                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
//                string screenshotPath = Path.Combine(textDir, "Screenshots", $"{Guid.NewGuid()}.png");
//                Directory.CreateDirectory(Path.GetDirectoryName(screenshotPath));
//                screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
//                if (stepType == "Given")
//                    _scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message)
//                                                         .AddScreenCaptureFromPath(screenshotPath);
//                else if (stepType == "When")
//                    _scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message)
//                                                        .AddScreenCaptureFromPath(screenshotPath);
//                else if (stepType == "Then")
//                    _scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message)
//                                                         .AddScreenCaptureFromPath(screenshotPath);
//                else if (stepType == "And")
//                    _scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message)
//                                                         .AddScreenCaptureFromPath(screenshotPath);

//            }
//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            // Any teardown or cleanup code if needed
//        }

//        [AfterTestRun]
//        public static void AfterTestRun()
//        {
//            _extentReports.Flush();
//        }
//    }
//}

//using OpenQA.Selenium;
//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Gherkin.Model;
//using OpenQA.Selenium.Appium.Windows;
//using AventStack.ExtentReports.Reporter.Config;
//using AventStack.ExtentReports.Reporter;



//using Reqnroll;

//namespace BluetoothPermission.Hooks
//{
//    [Binding]
//    public class Hooks
//    {
//        private static ExtentReports _extentReports;
//        private static ExtentTest _feature;
//        private static ExtentTest _scenario;
//        private string textDir;
//        private readonly ScenarioContext _scenarioContext;
//        private readonly FeatureContext _featureContext;
//        private WindowsDriver<WindowsElement> Driver;

//        public Hooks(ScenarioContext scenarioContext, FeatureContext featureContext)
//        {
//            _scenarioContext = scenarioContext;
//            _featureContext = featureContext;
//        }

//        [BeforeTestRun]
//        public static void BeforeTestRun()
//        {
//            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
//            string reportDirectory = "C:\\Users\\iray\\source\\repos\\connectingHIsBluetooth\\ExtentReport";
//            Directory.CreateDirectory(reportDirectory);
//            string reportFileName = Path.Combine(reportDirectory, $"Hello_{timestamp}.html");

//            Console.WriteLine($"Report will be saved as: {reportFileName}");

//            if (File.Exists(reportFileName))
//            {
//                File.Delete(reportFileName);
//                Console.WriteLine("Previous report file deleted.");
//            }
//        }

//        [BeforeFeature]
//        public static void BeforeFeature(FeatureContext featureContext)
//        {
//            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
//        }

//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            _scenario = _feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
//        }

//        [AfterStep]
//        public void AfterStep(ScenarioContext scenarioContext)
//        {
//            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
//            string stepName = scenarioContext.StepContext.StepInfo.Text;

//            if (_scenarioContext.TestError == null)
//            {
//                if (stepType == "Given")
//                    _scenario.CreateNode<Given>(stepName).Pass($"{stepName} passed");
//                else if (stepType == "When")
//                    _scenario.CreateNode<When>(stepName).Pass($"{stepName} passed");
//                else if (stepType == "Then")
//                    _scenario.CreateNode<Then>(stepName).Pass($"{stepName} passed");
//                else if (stepType == "And")
//                    _scenario.CreateNode<And>(stepName).Pass($"{stepName} passed");
//            }
//            else
//            {
//                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
//                string screenshotPath = Path.Combine(textDir, "Screenshots", $"{Guid.NewGuid()}.png");
//                Directory.CreateDirectory(Path.GetDirectoryName(screenshotPath));
//                screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

//                if (stepType == "Given")
//                    _scenario.CreateNode<Given>(stepName)
//                        .Fail(scenarioContext.TestError.Message)
//                        .AddScreenCaptureFromPath(screenshotPath);
//                else if (stepType == "When")
//                    _scenario.CreateNode<When>(stepName)
//                        .Fail(scenarioContext.TestError.Message)
//                        .AddScreenCaptureFromPath(screenshotPath);
//                else if (stepType == "Then")
//                    _scenario.CreateNode<Then>(stepName)
//                        .Fail(scenarioContext.TestError.Message)
//                        .AddScreenCaptureFromPath(screenshotPath);
//                else if (stepType == "And")
//                    _scenario.CreateNode<And>(stepName)
//                        .Fail(scenarioContext.TestError.Message)
//                        .AddScreenCaptureFromPath(screenshotPath);
//            }
//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            // Any teardown or cleanup code if needed
//        }

//        [AfterTestRun]
//        public static void AfterTestRun()
//        {
//            _extentReports.Flush();
//        }
//    }
//}
