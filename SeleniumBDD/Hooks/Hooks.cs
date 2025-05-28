using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using SeleniumBDD.Extent_Report;
using TechTalk.SpecFlow;

namespace SeleniumBDD.Hooks
{
    [Binding]
    public sealed class Hooks : ExtentReport
    {
        private readonly IObjectContainer _container;
       
        private readonly ScenarioContext _scenarioContext;
        public Hooks(IObjectContainer container, ScenarioContext scenarioContext)
        {
            _container = container;
            _scenarioContext = scenarioContext;
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
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
             _feature = _extent.CreateTest(featureContext.FeatureInfo.Title);
        }
        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            _scenario = _feature.CreateNode(_scenarioContext.ScenarioInfo.Title);

            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.webdriveruniversity.com/");

            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();
            if (driver != null)
            {
                Thread.Sleep(2000);
                driver.Quit();
            }
        }
        [AfterStep]
        public void AfterStep()
        {

            var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            var stepName = _scenarioContext.StepContext.StepInfo.Text;
            var driver = _container.Resolve<IWebDriver>();
            if (_scenarioContext.TestError == null)
            {
                _scenario.CreateNode(new GherkinKeyword(stepType), stepName);
            }
            else
            {
                string screenshot = AddScreenShot(driver, _scenarioContext);

                _scenario.CreateNode(new GherkinKeyword(stepType), stepName).Fail(_scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(screenshot).Build());
            }
        }
    }       
}