using BoDi;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;
using TestMultiplePlugins.Utilities;
using OpenQA.Selenium;
using TestMultiplePlugins.Drivers;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;
using OpenQA.Selenium.Appium.Service;
using SharpCompress.Writers;

namespace TestMultiplePlugins.Hooks
{
    [Binding]
    public sealed class Hooks1 : ExtentReport
    {
        private readonly IObjectContainer _container;   
        private readonly driverFactory _driver;      
        private static ScenarioContext _scenarioContext;
        public Hooks1(IObjectContainer container, ScenarioContext scenarioContext)
        {
            _container = container;
            _scenarioContext = scenarioContext;            
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentReportInit();
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtentReportTearDown();
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featurecontext)
        {
            _feature = _extentReports.CreateTest<Feature>(featurecontext.FeatureInfo.Title);
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("Running after feature...");
            driverFactory.StopAppiumServer();       
        }
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext _scenarioContext)
        {
            Console.WriteLine("Running before scenario...");
            driverFactory.LaunchTheApp();
            _scenario = _feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);          
            _container.RegisterInstanceAs<IWebDriver>(drivers._driver);
        }
        [AfterScenario]
        public void AfterScenario(ScenarioContext _scenarioContext)
        {
            Console.WriteLine("Running after scenario...");
            drivers._driver.Quit();
            var status = _scenarioContext.ScenarioExecutionStatus;
            switch (status)
            {
                case ScenarioExecutionStatus.TestError:
                    Console.WriteLine("Scenario failed!");
                    break;
                default:
                    Console.WriteLine($"Scenario status: {status}");
                    break;
            }          
        }
        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Running after step...");
            var stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            var stepName = scenarioContext.StepContext.StepInfo.Text;
            var driver = _container.Resolve<IWebDriver>();
            if (scenarioContext.TestError == null)
            {
                CreateStepNode(stepType, stepName);
            }
            else
            {
                CreateStepNodeWithFailure(stepType, stepName, driver, scenarioContext);
            }
        }
        private void CreateStepNode(string stepType, string stepName)
        {
            switch (stepType)
            {
                case "Given": _scenario.CreateNode<Given>(stepName); break;
                case "When": _scenario.CreateNode<When>(stepName); break;
                case "Then": _scenario.CreateNode<Then>(stepName); break;
                case "And": _scenario.CreateNode<And>(stepName); break;
                case "But": _scenario.CreateNode<And>(stepName); break;
            }
        }
        private void CreateStepNodeWithFailure(string stepType, string stepName, IWebDriver driver, ScenarioContext scenarioContext)
        {
            string screenshotPath = addScreenshot(driver, scenarioContext);
            switch (stepType)
            {
                case "Given":
                    _scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message,
                    MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build()); break;
                case "When":
                    _scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message,
                    MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build()); break;
                case "Then":
                    _scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message,
                    MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build()); break;
                case "And":
                    _scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message,
                    MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build()); break;
                case "But":
                    _scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message,
                    MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build()); break;
            }
        }
    }
}