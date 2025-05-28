using ApkFilewithAppium.Drivers;
using ApkFilewithAppium.Reports;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using TechTalk.SpecFlow;

namespace ApkFilewithAppium.Hooks
{
    [Binding]
    public sealed class Hooks1:ExtentReport
    {
        private ScenarioContext _scenarioContext;
        

        public Hooks1(ScenarioContext scenariocontext)
        {
            _scenarioContext = scenariocontext;
            
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            InitializeReport();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            TearDownReport();
            DriverFactory.StopAppiumServer();
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext _featureContext)
        {
            _feature = _extent.CreateTest<Feature>(_featureContext.FeatureInfo.Title);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            DriverFactory.LaunchTheApp();

           _scenario = _feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if(DriverFactory._driver != null)
            {
                DriverFactory._driver.Quit();
            }
        }

        [AfterStep]
        public void AfterStep()
        {
            string stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = _scenarioContext.StepContext.StepInfo.Text;

            if(_scenarioContext.TestError == null)
            {
                _scenario.CreateNode(new GherkinKeyword(stepType), stepName);
            }
            else
            {
                string screenshot = AddScreenShot(DriverFactory._driver, _scenarioContext);

                _scenario.CreateNode(new GherkinKeyword(stepType), stepName).Fail(_scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(screenshot).Build());
            }
        }
    }
}