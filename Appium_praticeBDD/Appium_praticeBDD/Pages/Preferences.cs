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
    public class Preferences
    {

        private readonly AndroidDriver<AndroidElement> driver;

        private readonly ControlHelpers controlHelpers;

        public Preferences(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
            controlHelpers = new ControlHelpers(driver);
            //android.widget.TextView[@resource-id="android:id/title" and @text="WiFi settings"]
        }
        By locator(string value) => By.XPath($"//android.widget.TextView[@resource-id=\"android:id/title\" and @text= '{value}']");
        By gettext(string value) => By.XPath("//android.widget.EditText[@resource-id=\"android:id/edit\"]");

        By button(string value) => By.XPath("//android.widget.Button[text(), '" + value + "']");
        private By Wificheckbox  => By.Id("android:id/checkbox");
        public void Checkbox()
        {
            controlHelpers.ClickCheckbox(Wificheckbox);
        }
        public void wifisettings(string value)
        {
            controlHelpers.ClickElement(locator(value));
        }
        public void EntertextBox(string value)
        {
            controlHelpers.Text(gettext(value), value);
        }
        public void ButtonOk(string value)
        {
            controlHelpers.OK(button(value));
        }
    }
}
