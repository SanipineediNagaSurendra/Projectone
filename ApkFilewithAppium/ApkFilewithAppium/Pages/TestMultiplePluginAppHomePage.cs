using ApkFilewithAppium.Utitlity;
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
    public class TestMultiplePluginAppHomePage
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ControlHelpers controlHelpers;
        public TestMultiplePluginAppHomePage(AppiumDriver<AndroidElement> driver)
        {
            this._driver = driver;
            controlHelpers = new ControlHelpers(_driver);
        }
        public void ClickOnHomePageElements(string value, string direction)
        {

            controlHelpers.ScrollAndClick(value, direction);
        }

        public void ClickOnHomePageElements(string value)
        {

            controlHelpers.ScrollAndClick(value);
        }



    }
}
