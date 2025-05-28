using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Service.Options;

public class DriverFactory
{
   
    public static AppiumDriver<AndroidElement> driver { get; set; }
    private static  AppiumLocalService _service;
   
    public static void Launchtheapp()
    {

        StartAppiumServer();

        if (_service == null || !_service.IsRunning)
        {
            throw new Exception("Appium server failed to start!");
        }
        var appiumOptions = new AppiumOptions();
        appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
        appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "vivo 1820");
        appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
        appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, "D:\\APK files\\ApiDemos-debug.apk");
        //appiumOptions.AddAdditionalCapability("udid", "OJRGROAUPVEIPRRK");
        //appiumOptions.AddAdditionalCapability("appPackage", "com.android.bbkmusic");
        //appiumOptions.AddAdditionalCapability("appActivity", "com.android.bbkmusic.WidgetToTrackActivity");
        appiumOptions.AddAdditionalCapability("ignoreHiddenApiPolicyError", true);
        appiumOptions.AddAdditionalCapability("appWaitDuration", 60000);
        appiumOptions.AddAdditionalCapability("noReset", true);
        

        AppiumDriver<AndroidElement> d1 = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);

        driver = d1;
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);



    }
    private static void StartAppiumServer()
    {
        if (_service == null || !_service.IsRunning)
        {
            _service = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                .UsingPort(4723)
                .UsingDriverExecutable(new FileInfo(@"C:\Program Files\nodejs\node.exe"))
                .WithAppiumJS(new FileInfo(@"C:\Users\nagas\AppData\Roaming\npm\node_modules\appium\build\lib\main.js"))
                .WithStartUpTimeOut(TimeSpan.FromSeconds(3))
                .Build();

            _service.Start();
           
        }

    }
    public static void StopAppiumServer()
    {
        if (_service != null && _service.IsRunning)
        {
            _service.Dispose();
            
        }
    }




}


