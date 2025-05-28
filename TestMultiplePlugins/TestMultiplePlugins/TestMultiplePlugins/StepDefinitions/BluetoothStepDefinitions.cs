using System;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Pages;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class BluetoothStepDefinitions
    {
        public static BluetoothPermission _btpermission = new BluetoothPermission();
        public static AppActions _actions = new AppActions();        
        [Given(@"I scroll ""([^""]*)"" and launch plugin '([^']*)'")]
        public void GivenIScrollAndLaunchPlugin(string down, string bluetoothPlugin)
        {
            _btpermission.scrollClick(down, bluetoothPlugin); 
        }
        [When(@"I press ""([^""]*)"" on BluetoothPermissionPluginPage")]
        public void WhenIPressOnBluetoothPermissionPluginPage(string ok)
        {
            _btpermission.clickOK();
        }
        [When(@"I ""([^""]*)"" permission request")]
        public void WhenIPermissionRequest(string permission)
        {
           _btpermission.permission(permission);
        }
        [When(@"I terminate and relaunch the plugin app")]
        public void WhenITerminateAndRelaunchThePluginApp()
        {
            _actions.relaunchapp();
        }
        [When(@"I scroll '([^']*)' and launch plugin ""([^""]*)""")]
        public void WhenIScrollAndLaunchPlugin(string down, string pairingPlugin)
        {
            _btpermission.scrollClick(down, pairingPlugin);
        }
    }
}
