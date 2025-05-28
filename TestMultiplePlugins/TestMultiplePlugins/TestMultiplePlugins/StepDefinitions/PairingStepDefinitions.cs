using System;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Hooks;
using TestMultiplePlugins.Pages;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class PairingStepDefinitions
    {
        public static  Homepage _homePage = new Homepage();
        public static ApplicationModePage _setAppMode = new ApplicationModePage();
        public static pairingHI _pairHI = new pairingHI();
        public static pairingservice _pairingservice = new pairingservice();
        public static pathPreset _pathpreset = new pathPreset();
        [Given(@"The user enables Dynamic service provider page after enabling '([^']*)'")]
        public void GivenTheUserEnablesDynamicServiceProviderPageAfterEnabling(string value)
        {
            _homePage.searchForvalue("manageapplication");
            _homePage.clickOption("manageapplication");
            _setAppMode.selectoption(value);
            _setAppMode.selectContinu();
        }
        [When(@"the user selects ""([^""]*)"" and sets the configuration")]
        public void WhenTheUserSelectsAndSetsTheConfiguration(string searchvalue)
        {
            _homePage.clickClose();
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
        [When(@"the user presets the path to ""([^""]*)""")]
        public void WhenTheUserPresetsThePathTo(string happy)
        {
            _pathpreset.SelectingTheOption();
            _pathpreset.searchFor(happy);                
            _pathpreset.selectOption(happy);
            _pathpreset.close();
        }
        [When(@"user starts pairing the HIs")]
        public void WhenUserStartsPairingTheHIs()
        {
            _homePage.clickClose();
            _homePage.searchForvalue("pairingplugin");
            _homePage.clickOption("pairingplugin");
            _pairHI.ConnectClick();
            _pairHI.ContinueClick();
            Thread.Sleep(3000);
        }
        [Then(@"verify if connected")]
        public void ThenVerifyIfConnected()
        {
            _pairHI.verifyConnection();
        }
    }
}
