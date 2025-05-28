using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Service.Options;
using System.Diagnostics;
using TechTalk.SpecFlow.Assist;

namespace AppiumPracticeBDD.Drivers
{
    public class DriverFactory
    {

        public static AppiumDriver<AndroidElement> driver { get; set; }
        public static void Launchtheapp()
        {
            starttheserver();
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "vivo 1933");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
            //appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, "D:\\APK files\\ApiDemos-debug.apk");
            appiumOptions.AddAdditionalCapability("appPackage", "com.android.settings");
            appiumOptions.AddAdditionalCapability("appActivity", "com.android.settings.Settings");
            appiumOptions.AddAdditionalCapability("ignoreHiddenApiPolicyError", true);
            appiumOptions.AddAdditionalCapability("appWaitDuration", 60000);
            appiumOptions.AddAdditionalCapability("noReset", true);
             Uri uri = new Uri("http://127.0.0.1:4723/wd/hub");

            AppiumDriver<AndroidElement> d1 = new AndroidDriver<AndroidElement>(uri, appiumOptions);

            driver = d1;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);



        }
        private static void starttheserver()
        {
            var server = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                .UsingPort(4723)
                .UsingDriverExecutable(new FileInfo(@"c:\Program Files\nodejs\node.exe"))
                .WithAppiumJS(new FileInfo(@"c:\Users\nagas\AppData\Roaming\npm\node_modules\appium\build\lib\main.js"))
                .WithStartUpTimeOut(TimeSpan.FromSeconds(3))
                .Build();
                server.Start();
            

        }

    
    }

}

