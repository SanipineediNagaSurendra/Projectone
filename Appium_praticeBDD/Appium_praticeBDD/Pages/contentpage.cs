using Appium_praticeBDD.Utiility;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium_praticeBDD.Pages
{
    public class contentpage
    {
        private readonly AndroidDriver<AndroidElement> driver;
        private readonly ControlHelpers controlHelpers;
        public contentpage(AndroidDriver<AndroidElement>driver) 
        {
            this.driver = driver;
            controlHelpers = new ControlHelpers(driver);
        }

        By locator(string text) => By.XPath("//android.widget.TextView[@resource-id=\"io.appium.android.apis:id/text\"]");

        public void getText(string value)
        {
            controlHelpers.GetText(locator(value), value);
        }
    }
   
}
