using AppiumPracticeBDD.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace AppiumPracticeBDD.StepDefinitions
{
    [Binding]
    public class PreferencesStepDefinitions
    {
        [Given(@"User click on ""([^""]*)"" button")]
        public void GivenUserClickOnButton(string p0)
        {

            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc= '"+p0+"']")).Click(); 
        }

        [When(@"user click on ""([^""]*)""")]
        public void WhenUserClickOn(string p1)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[contains(@content-desc, '"+p1+"')]")).Click();

            
        }

        [When(@"user checked on ""([^""]*)""")]
        public void WhenUserCheckedOn(string p0)
        {
            DriverFactory.driver.FindElement(By.Id("android:id/checkbox")).Click();
        }

        [When(@"user click on wifi settings")]
        public void WhenUserClickOnWifiSettings()
        {

            DriverFactory.driver.Orientation = ScreenOrientation.Landscape;
            DriverFactory.driver.FindElement(By.XPath("(//android.widget.RelativeLayout)[2]")).Click();
           
           

           // DriverFactory.driver.FindElement(By.Id("android:id/edit")).SendKeys("surendra wifi");
            DriverFactory.driver.FindElements(By.ClassName("android.widget.Button"))[1].Click();
           
            
            Thread.Sleep(1000);

        }

        [Then(@"wifi settings popup should be dispalyed")]
        public void ThenWifiSettingsPopupShouldBeDispalyed()
        {
            string str = DriverFactory.driver.FindElement(By.Id("android:id/alertTitle")).Text;

            Assert.AreEqual(str, "WiFi settings");
            
        }
        static void SendKeyEvent(int keyCode)
        {
            var process = new Process();
            process.StartInfo.FileName = "adb";
            process.StartInfo.Arguments = $"shell input keyevent {keyCode}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            process.WaitForExit();
        }
    }
}
