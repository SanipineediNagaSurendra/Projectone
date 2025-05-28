using System;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Hooks;
using TestMultiplePlugins.Pages;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class NodevicePairingStepDefinitions
    {
        public static Homepage _homePage = new Homepage();
        public static ApplicationModePage _setAppMode = new ApplicationModePage();
        public static pairingHI _pairHI = new pairingHI();
        public static pairingservice _pairingservice = new pairingservice();
        public static pathPreset _pathpreset = new pathPreset();
        public static RestartHI _restartHI = new RestartHI();
        public static SelectHI _selectHI = new SelectHI();  
        [Given(@"the user enables Dynamic service provider page after enabling '([^']*)'")]
        public void GivenTheUserEnablesDynamicServiceProviderPageAfterEnabling(string value)
        {
            _homePage.searchForvalue("manageapplication");
            _homePage.clickOption("manageapplication");
            _setAppMode.selectoption(value);
            _setAppMode.selectContinu();
            _homePage.clickClose();
        }
        [When(@"the user select ""([^""]*)"" and sets the configuration")]
        public void WhenTheUserSelectAndSetsTheConfiguration(string searchvalue)
        {
            _homePage.searchForvalue("dynamicserviceprovider");
            _homePage.clickOption("dynamicserviceprovider");
            _homePage.searchForvalue(searchvalue);
            _homePage.clickOption(searchvalue);
            _pairingservice.clicknewConfiguration();
            _pairingservice.setConfiguration();
            _pairingservice.clickconfiguration();
            _pairingservice.selectConfigurationOption("Activate");
            _pairingservice.clickconfiguration();
            _pairingservice.selectConfigurationOption("Edit");
        }
        [When(@"the user presetting the path to ""([^""]*)""")]
        public void WhenTheUserPresettingThePathTo(string searchValue)
        {
            _pathpreset.SelectingTheOption();
            _pathpreset.searchFor(searchValue);               
            _pathpreset.selectOption(searchValue);
            _pathpreset.close();
        }
        [When(@"user initiates restarting HIs")]
        public void WhenUserInitiatesRestartingHIs()
        {
            _homePage.searchForvalue("pairingplugin");
            _homePage.clickOption("pairingplugin");
            _restartHI.ShowMeHowClick();
        }
        [Then(@"verify if  rechargeable is displayed")]
        public void ThenVerifyIfRechargeableIsDisplayed()
        {
            _selectHI.gettext("Rechargeable");
            _selectHI.AssertDisplayedText("Rechargeable");
        }
    }
}
