using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp_BDD.Drivers
{
    public class DriverFactory
    {
        public static AppiumDriver<AndroidElement> driver {get; set;}
        public static void LauchTheApp()
        {
            var appiumoptions = new AppiumOptions();
            appiumoptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumoptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Vivo 1820");
            
            appiumoptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
            appiumoptions.AddAdditionalCapability(MobileCapabilityType.App, "D:\\APK files\\General-Store.apk");
            appiumoptions.AddAdditionalCapability("ignoreHiddenApiPolicyError", true);
            appiumoptions.AddAdditionalCapability("appWaitDuration", 60000);
            appiumoptions.AddAdditionalCapability("noReset", true);
            Uri uri = new Uri("http://127.0.0.1:4723/wd/hub");

            AppiumDriver<AndroidElement> d1 = new AndroidDriver<AndroidElement>(uri, appiumoptions);
            driver = d1;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }


    }
}
