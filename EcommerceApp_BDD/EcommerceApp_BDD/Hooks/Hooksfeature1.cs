using EcommerceApp_BDD.Drivers;
using TechTalk.SpecFlow;

namespace EcommerceApp_BDD.Hooks
{
    [Binding]
    public sealed class Hooksfeature1
    {
        
        

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            DriverFactory.LauchTheApp();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverFactory.driver.Quit();
        }
    }
}