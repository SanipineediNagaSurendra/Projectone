using System;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Hooks;
using TestMultiplePlugins.Pages;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class RestartPairingStepDefinitions
    {
        public static Homepage _homePage = new Homepage();
        public static RestartHI _restartHI = new RestartHI();
        public static SearchAndConnect _searchConnect = new SearchAndConnect();        
        [When(@"the user cliks the restart button")]
        public void WhenTheUserCliksTheRestartButton()
        {
            _homePage.searchForvalue("pairingplugin");
            _homePage.clickOption("pairingplugin");
            _restartHI.RestartedClick();
        }
        [Then(@"verify if ""([^""]*)"" is displayed")]
        public void ThenVerifyIfIsDisplayed(string searchText)
        {
            _searchConnect.VerifySearch(searchText);
        }
        [When(@"user clicks close button")]
        public void WhenUserClicksCloseButton()
        {
            _searchConnect.clickClose();
        }
        [Then(@"verify ""([^""]*)"" is displayed")]
        public void ThenVerifyIsDisplayed(string exit)
        {
            _searchConnect.VerifyOption(exit);
        }
    }
}
