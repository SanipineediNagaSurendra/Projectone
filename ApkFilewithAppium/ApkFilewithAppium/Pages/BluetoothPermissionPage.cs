using ApkFilewithAppium.Utitlity;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkFilewithAppium.Pages
{
    public class BluetoothPermissionPage
    {
        private AppiumDriver<AndroidElement> _driver;
        public readonly ControlHelpers controlHelpers;

        public BluetoothPermissionPage(AppiumDriver<AndroidElement> driver)
        {
            this._driver = driver;
            controlHelpers = new ControlHelpers(_driver);


        }


        protected By BluetoothPageelements(string value, string pageSection) =>
        By.XPath($"//*[@class='android.widget.{pageSection}' and contains(@text, '{value}')]");

        protected By Bluettothpermission(string value) => By.XPath("//android.widget.Button[contains(@text, '" + value + "')]");

        protected By BluetoothPageelements(string value) => By.XPath("//android.widget.TextView[contains(@text, '" + value + "')]");

       
        public void BluetoothpermissionPageElements(string value, string page)
        {
            controlHelpers.ClickMethod(BluetoothPageelements(value, page));
        }
        public void VerifyOkBtn(string value , string status, string page)
        {
            controlHelpers.VerifyelementisDispalyed(value, status, page);
        }

       
        public void ClickOnOkButton(string text, string page)
        {
            controlHelpers.ClickMethod(Bluettothpermission(text));

        }
        public void ClickOnOkButton(string text)
        {
            controlHelpers.ClickMethod(Bluettothpermission(text));
        }


        public void verifyNearByDeviceelement()
        {

            var ele = controlHelpers.GetElement(By.XPath("//android.widget.FrameLayout[contains(@content-desc, 'Nearby devices permission')]"));

            if(ele.Displayed)
            {
                Assert.IsTrue(ele.Displayed, "element is not found");
            }
            else
            {
                Assert.IsFalse(ele.Displayed, "element is found");
            }

           
        }
        
        

    }
}
