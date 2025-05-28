using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkFilewithAppium.Drivers
{
    public class DriverFactory
    {
        public static AppiumDriver<AndroidElement> _driver { get; set; }
        private static AppiumLocalService _service;

        public static void LaunchTheApp()
        {
            try
            {
                if (_service == null)
                {
                    StartAppiumServer();
                    Console.WriteLine("server will start");
                }
                else
                {
                    Console.WriteLine("server already start");
                }


                var options = new AppiumOptions();

                options.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                options.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
                options.AddAdditionalCapability(MobileCapabilityType.DeviceName, "SM G970F");
                //options.AddAdditionalCapability("appPackage", "com.android.settings");
                //options.AddAdditionalCapability("appActivity", "com.android.settings.Settings");
                options.AddAdditionalCapability(MobileCapabilityType.App, "D:\\APK files\\TestMultiplePlugins (1).apk");
                //options.AddAdditionalCapability(MobileCapabilityType.Udid, "RZ8M21Q1RGR ");
                options.AddAdditionalCapability("ignoreHiddenApiPolicyError", "true");
                //options.AddAdditionalCapability("appWaitDuration", 60000);

                AppiumDriver<AndroidElement> d1 = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), options);

                _driver = d1;

                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static void StartAppiumServer()
        {
            _service = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                .UsingPort(4723)
                .UsingDriverExecutable(new FileInfo(@"C:\Program Files\nodejs\node.exe"))
                .WithAppiumJS(new FileInfo(@"C:\Users\nagas\AppData\Roaming\npm\node_modules\appium\build\lib\main.js"))

                .WithStartUpTimeOut(TimeSpan.FromSeconds(10))
                .Build();

            _service.Start();
        }
        public void StopAppiumServer()
        {
            if(_service != null || _service.IsRunning)
            {
                 _service.Dispose();
            }
        }
    }
}
