using System;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Pages;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class BodyDescriptionStepDefinitions
    {
        public static AppActions _actions = new AppActions();
        public static Settings _settings = new Settings();  
        [When(@"I go to native settings")]
        public void WhenIGoToNativeSettings()
        {
            _actions.launchsettings();
        }
        [When(@"I press '([^']*)' button on Settings Page and Turn '([^']*)' bluetooth")]
        public void WhenIPressButtonOnSettingsPageAndTurnBluetooth(string bluetooth, string toggleOption)
        {
            _settings.clickConnectedDevices();
            _settings.clickConnectpreference();
            _settings.clickBluetooth();
            _settings.TurnBlurtooth(toggleOption);
        }
        [When(@"I relaunch the plugin app")]
        public void WhenIRelaunchThePluginApp()
        {
            _actions.launchapp();
        }
    }
}
