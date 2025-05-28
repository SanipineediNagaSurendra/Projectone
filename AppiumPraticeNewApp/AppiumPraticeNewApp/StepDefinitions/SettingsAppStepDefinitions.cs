using AppiumPraticeNewApp.Drivers;
using AppiumPraticeNewApp.Hooks;
using System;
using TechTalk.SpecFlow;

namespace AppiumPraticeNewApp.StepDefinitions
{
    [Binding]
    public class SettingsAppStepDefinitions
    {
        [Given(@"I launch the settings app")]
        public void GivenILaunchTheSettingsApp()
        {
            Console.WriteLine("App is already launched in Hooks class");
        }

        [Then(@"user can verify '([^']*)' header on Homepage")]
        public void ThenUserCanVerifyHeaderOnHomepage(string settings)
        {
            
        }

        [When(@"user click on the '([^']*)'")]
        public void WhenUserClickOnThe(string messages)
        {
            
        }

        [When(@"user click on the Shortcut Buttons Enable button")]
        public void WhenUserClickOnTheShortcutButtonsEnableButton()
        {
            
        }

        [Then(@"verify enable button is enabled")]
        public void ThenVerifyEnableButtonIsEnabled()
        {
           
        }
    }
}
