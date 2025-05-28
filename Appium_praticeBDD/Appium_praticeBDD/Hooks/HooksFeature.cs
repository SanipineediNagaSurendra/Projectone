using Appium_praticeBDD.Extent_Reports;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace Appium_praticeBDD.Hooks
{
    [Binding]
    public sealed class HooksFeature:ExtentReportFeature
    {
        private readonly IObjectContainer _container;
        private readonly ScenarioContext _scenarioContext;
        private AppiumDriver<AndroidElement> driver;

        public HooksFeature(IObjectContainer container, ScenarioContext scenarioContext )
        {
            _container = container;
            _scenarioContext = scenarioContext;
           
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentReportFeature.InitializeReport(); // Ensures only one instance
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtentReportFeature.TearDownReport();
            DriverFactory.StopAppiumServer();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            _feature = _extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }
        

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            DriverFactory.Launchtheapp();
            _container.RegisterInstanceAs<AppiumDriver<AndroidElement>>(DriverFactory.driver);

            _scenario = _feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (DriverFactory.driver != null)
            {
                DriverFactory.driver.Quit();
            }
        }

        [AfterStep]
        public void AfterStep()
        {
            string stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            var stepName = _scenarioContext.StepContext.StepInfo.Text;

            var driver = _container.Resolve<AppiumDriver<AndroidElement>>();

            if (_scenarioContext.TestError == null)
            {
                _scenario.CreateNode(new GherkinKeyword(stepType), stepName);
            }
            else
            {
                string screenshotPath = AddScreenShot(DriverFactory.driver, _scenarioContext);

                _scenario.CreateNode(new GherkinKeyword(stepType), stepName)
                        .Fail(_scenarioContext.TestError.Message,
                              MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            }
        }
    }
}
