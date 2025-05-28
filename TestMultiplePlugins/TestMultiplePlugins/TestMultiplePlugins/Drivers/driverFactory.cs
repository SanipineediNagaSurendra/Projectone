using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Drivers
{
    public class driverFactory
    {
       // public static AppiumDriver<AndroidElement> _driver;
        private static AppiumLocalService _service;
        public static void LaunchTheApp()
        {
            StartAppiumServer();
            var options = new AppiumOptions();
            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            options.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 3a XL");  //Galaxy S10e  Pixel 3a XL
            options.AddAdditionalCapability("appPackage", "com.ReSound.TestMultiplePlugins");
            options.AddAdditionalCapability("appActivity", "crc647f80cf2a2d0a06ff.MainActivity");
            options.AddAdditionalCapability(MobileCapabilityType.Udid, "93KAX08G4E"); //RZ8M21Q1RGR
            options.AddAdditionalCapability("ignoreHiddenApiPolicyError", "true");
            options.AddAdditionalCapability("appWaitDuration", 60000);
            AppiumDriver<AndroidElement> d1 = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), options);
         //   _driver = d1;
            drivers._driver = d1;
        }        
        private static void StartAppiumServer()
        {
            _service = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                .UsingPort(4723)
                .UsingDriverExecutable(new FileInfo(@"C:\Program Files\nodejs\node.exe"))
                .WithAppiumJS(new FileInfo(@"C:\Users\iray\AppData\Roaming\npm\node_modules\appium\build\lib\main.js"))
                .WithStartUpTimeOut(TimeSpan.FromSeconds(10))
                .Build();
            _service.Start();
        }
        public static void StopAppiumServer()
        {
            if (_service != null || _service.IsRunning)
            {
                _service.Dispose();
            }
        }
    }
}
