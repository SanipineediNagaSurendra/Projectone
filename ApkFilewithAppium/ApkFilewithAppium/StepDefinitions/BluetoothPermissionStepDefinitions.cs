using ApkFilewithAppium.Drivers;
using ApkFilewithAppium.Pages;
using ApkFilewithAppium.Utitlity;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace ApkFilewithAppium.StepDefinitions
{
    [Binding]
    public class BluetoothPermissionStepDefinitions
    {
        
        TestMultiplePluginAppHomePage _page = new TestMultiplePluginAppHomePage(DriverFactory._driver);
    
        
        BluetoothSettingsPage _pagebase = new BluetoothSettingsPage(DriverFactory._driver);
      


        [Given(@"I launch the plugin app")]
        public void GivenILaunchThePluginApp()
        {
            Console.WriteLine("App is already launched in Hooks Class");
        }

        [Given(@"I scroll '([^']*)' and launch plugin '([^']*)'")]
        public void GivenIScrollAndLaunchPlugin(string direction, string bluetoothPermissionPlugin)
        {
            _page.ClickOnHomePageElements(direction, bluetoothPermissionPlugin);
        }

        [Then(@"verify '([^']*)' is '([^']*)' on '([^']*)'")]
        public void ThenVerifyIsOn(string ok, string displayed, string bluetoothPermissionPluginPage)
        {

            _pagebase.VerifyOkBtn(ok, displayed, bluetoothPermissionPluginPage);
            
        }
     
        [When(@"I press '([^']*)' on '([^']*)'")]
        public void GivenIPressOn(string ok, string bluetoothPermissionPluginPage)
        {
            _pagebase.ClickOnOkButton(ok, bluetoothPermissionPluginPage);
        }

        [When(@"I '([^']*)' permission request")]
        public void WhenIPermissionRequest(string deny)
        {
            _pagebase.ClickOnOkButton(deny);
        }
        [When(@"I terminate and relaunch the plugin app")]
        public void WhenITerminateAndRelaunchThePluginApp()
        {
           
            DriverFactory._driver.TerminateApp("com.ReSound.TestMultiplePlugins");
            Thread.Sleep(5000);
            DriverFactory._driver.ActivateApp("com.ReSound.TestMultiplePlugins");
           

        }

        [Then(@"verify plugin is completed")]
        public void ThenVerifyPluginIsCompleted()
        {
            _pagebase.verifyNearByDeviceelement();
           
        }


        [Then(@"verify permission request alert is displayed and close alert")]
        public void ThenVerifyPermissionRequestAlertIsDisplayedAndCloseAlert()
        {
            try
            {
                IAlert alert = DriverFactory._driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail(e.Message);
            }
            
            
        }
        [When(@"I close and restart the TestSinglePluginApp")]
        public void WhenICloseAndRestartTheTestSinglePluginApp()
        {
            var driver = (AndroidDriver<AndroidElement>)DriverFactory._driver;
            driver.PressKeyCode(AndroidKeyCode.Home);
            driver.ActivateApp(" com.ReSound.TestMultiplePlugins");
        }
       
    

        [When(@"I scroll '([^']*)' and press '([^']*)' on '([^']*)'")]
        public void WhenIScrollAndPressOn(string down, string nearbyDevices, string nativeSettingsPage)
        {
            _pagebase.Bluetoothsettingpageelement(down, nearbyDevices, nativeSettingsPage);
        }


        [When(@"I press '([^']*)' text on '([^']*)'")]
        public void WhenIPressTextOn(string permissions, string nativeSettingsPage)
        {
           _pagebase.Bluetoothsettingpageelement(permissions, nativeSettingsPage);
        }

        [When(@"I press '([^']*)' button on '([^']*)'")]
        public void WhenIPressButtonOn(string allow, string nativeSettingsPage)
        {
            _pagebase.RadioButtonclick(allow, nativeSettingsPage);
        }

       





    }
}
