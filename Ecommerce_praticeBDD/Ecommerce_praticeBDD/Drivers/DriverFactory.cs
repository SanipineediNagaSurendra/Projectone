using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_praticeBDD.Drivers
{
    public class DriverFactory
    {
        
        public static AppiumDriver<AndroidElement> driver { get; set; }
        public static void LaunchTheApp()
        {
            
              
            StartServer();
            var options = new AppiumOptions();
            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            options.AddAdditionalCapability(MobileCapabilityType.AutomationName, "uiautomator2");
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, "vivo 1820");
            options.AddAdditionalCapability(MobileCapabilityType.App, "D:\\APK files\\General-Store.apk");
            options.AddAdditionalCapability("ignoreHiddenApiPolicyError", "true");
            options.AddAdditionalCapability("appWaitDuration", "50000");
            options.AddAdditionalCapability("noReset", "true");

            AppiumDriver<AndroidElement> d2 = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), options);
            driver = d2;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60); //implict wait
            
            
        }
        private static void StartServer()
        {
            var server = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                .UsingPort(4723)
                .UsingDriverExecutable(new FileInfo(@"c:\Program Files\nodejs\node.exe"))
                .WithAppiumJS(new FileInfo(@"C:\Users\nagas\AppData\Roaming\npm\node_modules\appium\build\lib\main.js"))
                .Build();
            server.Start();
                
        }
    }
}
