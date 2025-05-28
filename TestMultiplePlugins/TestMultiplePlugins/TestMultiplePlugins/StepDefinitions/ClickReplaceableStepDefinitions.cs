using System;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Hooks;
using TestMultiplePlugins.Pages;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class ClickReplaceableStepDefinitions
    {
        public static SelectHI _selectHIOptions = new SelectHI();
        public static Verify _verify = new Verify();
        [When(@"user clicks Replaceable battery")]
        public void WhenUserClicksReplaceableBattery()
        {
            _selectHIOptions.ClickReplaceable();
        }
        [Then(@"verify if the option clicked")]
        public void ThenVerifyIfTheOptionClicked()
        {
            _verify.VerifyThePageIsDisplayed();
        }
    }
}