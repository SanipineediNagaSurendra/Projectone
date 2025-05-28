using BluetoothPermission.Drivers;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using Reqnroll.BoDi;
using System.Reflection;
using BluetoothPermission.Pages;
using Reqnroll;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Diagnostics;

namespace BluetoothPermission.StepDefinitions
{
    [Binding]
    public class steps
    {
        private IObjectContainer _container;
        private ScenarioContext _scenarioContext;
        private Pagebase pagebase;
        private BluetoothPermissionPluginPage bluetoothpermissionpluginpage;
        private AndroidDriver<AndroidElement> driverr;
        

        public steps(IObjectContainer container, ScenarioContext scenarioContext)
        {
            _container = container;
            _scenarioContext = scenarioContext;
            pagebase = new Pagebase();
            bluetoothpermissionpluginpage = new BluetoothPermissionPluginPage();

        }
        


        [Given("I launch the plugin app")]
        public void GivenILaunchThePluginApp()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("platformVersion", "13");
            appiumOptions.AddAdditionalCapability("deviceName", "Samsung galaxy A54");
            appiumOptions.AddAdditionalCapability("udid", "RZCR90DL9KX");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray\\source\\TestMultiplePlugins.apk");
            appiumOptions.AddAdditionalCapability("adbExecTimeout", 50000);

            var httpClient1 = new HttpClient();
            httpClient1.Timeout = TimeSpan.FromSeconds(1000);
            var commandExecutor1 = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(1000));
            driverr = new AndroidDriver<AndroidElement>(commandExecutor1, appiumOptions);
            _container.RegisterInstanceAs<AppiumDriver<AndroidElement>>(driverr);
            driverr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
            drivers.driver1 = driverr;
        }

        [Given("I scroll {string} and launch plugin {string}")]
        [When("I scroll {string} and launch plugin {string}")]
        public void GivenIScrollAndLaunchPlugin(string down, string bluetoothPermissionPlugin)
        {
            pagebase.ScrollAndClickElement(down, bluetoothPermissionPlugin);
        }
       
       


        [Then("verify {string} is {string} on {string}")]
        public void ThenVerifyIsOn(string ok, string isDisplayed, string pagename)
        {
            // var page = CreatePageInstance(pagename);
            var page = new BluetoothPermissionPluginPage();
            bool expectedVisibility = isDisplayed.ToLower() == "displayed";
            try
            {
                if (expectedVisibility)
                    pagebase.WaitForElementToBeVisible(page, ok, 30);

                else
                    switch (isDisplayed)
                    {
                        case "enabled":
                            Assert.AreEqual(page.FindElement(ok).Text, "1");
                            break;
                        case "disabled":
                            Assert.AreEqual(page.FindElement(ok).Text, "0");
                            break;
                        case "enable":
                            Assert.AreEqual(page.FindElement(ok).Enabled.ToString(), "True");
                            break;
                        case "disable":
                            Assert.AreEqual(page.FindElement(ok).Enabled.ToString(), "False");
                            break;
                        default:
                            pagebase.WaitForElementToBeNotVisible(page, ok, 5);
                            break;
                    }
            }
            catch (Exception e)
            {
                throw new Exception("Thrown exception : " + e);
            }
        }

        [Given("I press {string} on {string}")]
        [When("I press {string} on {string}")]

        public void GivenIPressOn(string ok, string bluetoothPermissionPluginPage)
        {
            //  pagebase.button(ok, bluetoothPermissionPluginPage);
            bluetoothpermissionpluginpage.clickelement(ok);
        }
        

        [When("I {string} permission request")]
        public void WhenIPermissionRequest(string deny)
        {
            bluetoothpermissionpluginpage.clickelement(deny);
        }
        [When("I terminate and relaunch the plugin app")]
        public void WhenITerminateAndRelaunchThePluginApp()
        {
            drivers.driver1.TerminateApp("com.ReSound.TestMultiplePlugins");
            Thread.Sleep(5000);
            drivers.driver1.ActivateApp("com.ReSound.TestMultiplePlugins");

        }
        [Then("verify plugin is completed")]
        public void ThenVerifyPluginIsCompleted()
        {
            ThenVerifyIsOn("Search", "displayed", "BluetoothPermissionPluginPage");
        }

        [Then("verify permission request alert is displayed and close alert")]
        public void ThenVerifyPermissionRequestAlertIsDisplayedAndCloseAlert()
        {
            try
            {
                var wait = new WebDriverWait(drivers.driver1, TimeSpan.FromSeconds(15));
                var alert = driverr.SwitchTo().Alert();
                alert.Accept();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail(e.Message);
            }
        }
        [When("I scroll {string} and press {string} on {string}")]
        public void WhenIScrollAndPressOn(string down, string nearbyDevices, string bluetoothPermissionPluginPage)
        {
            pagebase.ScrollAndClickNearbydevices(down,nearbyDevices,bluetoothPermissionPluginPage);
        }
        [When("I relaunch the plugin app")]
        public void WhenIRelaunchThePluginApp()
        {
            var driver = (AndroidDriver<AndroidElement>)drivers.driver1;
            driver.PressKeyCode(AndroidKeyCode.Home);
            Thread.Sleep(3000);
            driver.ActivateApp("com.ReSound.TestMultiplePlugins");
        }





    }
}
