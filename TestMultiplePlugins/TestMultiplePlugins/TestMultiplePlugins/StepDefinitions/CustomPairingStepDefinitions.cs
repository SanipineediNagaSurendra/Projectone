using System;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Pages;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class CustomPairingStepDefinitions
    {
        public static SelectHI _selectHIOptions = new SelectHI();
        public static Verify _verify = new Verify();
        [When(@"the user scrolls ""([^""]*)"" and clicks on ""([^""]*)""")]
        public void WhenTheUserScrollsAndClicksOn(string direction, string custom)
        {
           _selectHIOptions.scrollAndClick(direction, custom);
        }
        [When(@"the user clicks customs")]
        public void WhenTheUserClicksCustoms()
        {
            _selectHIOptions.ClickCustoms();            
        }
    }
}
