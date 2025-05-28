using System;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Hooks;
using TestMultiplePlugins.Pages;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class TurnOnHIsStepDefinitions
    {
        public static Verify _verify = new Verify();
        public static Homepage _homePage = new Homepage();
        [When(@"user clicks ""([^""]*)""")]
        public void WhenUserClicks(string searchValue)
        {
            _homePage.searchForvalue(searchValue);
            _homePage.clickOption(searchValue);
        }

        [Then(@"verify the text ""([^""]*)"" is displayed")]
        public void ThenVerifyTheTextIsDisplayed(string text)
        {
            _verify.verifytext(text);
        }
        [Then(@"verify text ""([^""]*)"" is displayed")]
        public void ThenVerifyTextIsDisplayed(string button)
        {
            _verify.verifyButton(button);
        }

    }
}
