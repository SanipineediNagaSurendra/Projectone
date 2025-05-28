using ApkFilewithAppium.Utitlity;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApkFilewithAppium.Pages
{
    public class BluetoothSettingsPage : BluetoothPermissionPage
    {
        private AppiumDriver<AndroidElement> _driver;
      

        public BluetoothSettingsPage(AppiumDriver<AndroidElement> driver) :base(driver)
        {
            this._driver = driver;
         
        }

        
        protected By RadioButtons(string value) => By.XPath("//android.widget.RadioButton[contains(@text, '" + value + "')]");
       
        public void Bluetoothsettingpageelement(string value, string direction, string page)
        {
           controlHelpers.ScrollAndClickGivenElement(value, direction, page);
        }
        public void Bluetoothsettingpageelement(string value, string page)
        {
            controlHelpers.ClickMethod(BluetoothPageelements(value));  
        }
        public void RadioButtonclick(string value, string page)
        {
            controlHelpers.ClickMethod(RadioButtons(value));
        }

       
    }
}
