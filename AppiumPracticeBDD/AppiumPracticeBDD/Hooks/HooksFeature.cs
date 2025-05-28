using AppiumPracticeBDD.Drivers;
using OpenQA.Selenium.Appium.Service;
using TechTalk.SpecFlow;

namespace AppiumPracticeBDD.Hooks
{
    [Binding]
    public sealed class HooksFeature
    {
     

        [BeforeScenario(Order = 1)]
        public  void FirstBeforeScenario()
        {
            DriverFactory.Launchtheapp();
        }
        

        [AfterScenario]
        public void AfterScenario()
        {
           DriverFactory.driver.Quit();
        }
    }
}