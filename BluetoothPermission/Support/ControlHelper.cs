using BluetoothPermission.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluetoothPermission.Support
{
   public  class ControlHelper
   {
        public AndroidElement getElement(By Locator)
        {
            return drivers.driver1.FindElement(Locator);
        }
        public void ButtonClick(By Locator)
        {
            getElement(Locator).Click();
        }
    }
}
