using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using Ecommerce_praticeBDD.Drivers;
using Ecommerce_praticeBDD.ExtentReport;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace Ecommerce_praticeBDD.Hooks
{
    [Binding]
    public sealed class HooksFeature:ExtentReportsetup
    {
        private readonly IObjectContainer _container;
        

        public HooksFeature(IObjectContainer container)
        {
            _container = container;
            
        }

        [BeforeTestRun]
        public static void BeforeFeature()
        {
            InitializeReport();
        }
        [AfterTestRun]
        public static void AfterFeature()
        {
            TearDownReport();
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featurecontext)
        {
          feature = extent.CreateTest<Feature>(featurecontext.FeatureInfo.Title);
        }
        [AfterFeature]
        public static void Afterfeature()
        {
            DriverFactory.driver.Dispose();
        }
        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(ScenarioContext scenariocontext)
        {
            
            
            DriverFactory.LaunchTheApp();
            
            _container.RegisterInstanceAs<AppiumDriver<AndroidElement>>(DriverFactory.driver);
            Scenario = feature.CreateNode<Scenario>(scenariocontext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverFactory.driver.Quit();
        }
        public void RetryFailedScenario()
        {
            if(ScenarioContext.Current.TestError != null)
            {
                ScenarioContext.Current.Pending();
            }
        }
        [AfterStep]
        public void Afterstep(ScenarioContext scenariocontext)
        {
            string stepType = scenariocontext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenariocontext.StepContext.StepInfo.Text;
           

            var driver = _container.Resolve<AppiumDriver<AndroidElement>>();
            if (scenariocontext.TestError == null)
            {
                if(stepType == "Given")
                {
                    Scenario.CreateNode<Given>(stepName);
                }
                else if(stepType == "When")
                {
                    Scenario.CreateNode<When>(stepName);

                }
                else if(stepType == "Then")
                {
                    Scenario.CreateNode<Then>(stepName);
                }
                else if(stepType == "And")
                {
                    Scenario.CreateNode<And>(stepName);
                }
            }
            if(scenariocontext.TestError != null)
            {
                if(stepType == "Given")
                {
                    Scenario.CreateNode<Given>(stepName).Fail(scenariocontext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(AddScreenShot(driver, scenariocontext)).Build());
                }
                else if(stepType == "When")
                {
                    Scenario.CreateNode<When>(stepName).Fail(scenariocontext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(AddScreenShot(driver, scenariocontext)).Build());
                }
                else if(stepType == "Then")
                {
                    Scenario.CreateNode<Then>(stepName).Fail(scenariocontext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(AddScreenShot(driver, scenariocontext)).Build());
                }
                else if (stepType == "And")
                {
                    Scenario.CreateNode<And>(stepName).Fail(scenariocontext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(AddScreenShot(driver, scenariocontext)).Build());
                }
            }
        }
    }
}