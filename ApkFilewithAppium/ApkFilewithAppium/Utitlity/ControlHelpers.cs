using ApkFilewithAppium.Drivers;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApkFilewithAppium.Utitlity
{
    public class ControlHelpers
    {
        private AppiumDriver<AndroidElement> _driver;
        public ControlHelpers(AppiumDriver<AndroidElement> driver)
        {
            this._driver = driver;
        }

        public void ScrollAndClick(string direction, string text)
        {

            string baseScrollCommand = "new UiScrollable(new UiSelector().scrollable(true))";

            string fullCommand = direction.ToLower() switch
            {
                "down" => $"{baseScrollCommand}.scrollIntoView(new UiSelector().textContains(\"{text}\"))",
                "up" => $"{baseScrollCommand}.setAsVerticalList().scrollBackward().scrollIntoView(new UiSelector().text(\"{text}\"))",
                "left" => $"{baseScrollCommand}.setAsHorizontalList().scrollForward().scrollIntoView(new UiSelector().text(\"{text}\"))",
                "Right" => $"{baseScrollCommand}.setAsHorizontalList().scrollBackward().scrollIntoView(new UiSelector().text(\"{text}\"))",
                _ => throw new ArgumentException($"Invalid scroll direction: {direction}")
            } ;


            var element = GetElement(MobileBy.AndroidUIAutomator(fullCommand));
            element.Click();

        }


        public IWebElement GetElement(By locator)
        {
           return DriverFactory._driver.FindElement(locator);
        }

        public void VerifyelementisDispalyed(string element, string status, string elementpage)
        {
            try
            {
                string xpath = $"//android.widget.Button[contains(@text, '{element}')] | //android.widget.TextView[contains(@text, '{element}')]";

                var ele = GetElement(By.XPath(xpath));

                if (status.ToLower() == "displayed")
                {
                    Assert.IsTrue(ele.Displayed, $"{element} should be displayed on {elementpage}");
                }
                else
                {
                    throw new ArgumentException($"Unsupported condition: {ele}");
                }
            }
            catch
            {
                Assert.Fail($"{element} was not found on {elementpage}");
            }

            
        }

       
        public void ClickMethod(By Locator)
        {
            var ele = GetElement(Locator);
            ele.Click();
        }

        public void ScrollAndClickGivenElement(string direction, string text, string page)
        {

            string baseScrollCommand = "new UiScrollable(new UiSelector().scrollable(true))";

            string fullCommand = direction.ToLower() switch
            {
                "down" => $"{baseScrollCommand}.scrollIntoView(new UiSelector().textContains(\"{text}\"))",
                "up" => $"{baseScrollCommand}.setAsVerticalList().scrollBackward().scrollIntoView(new UiSelector().text(\"{text}\"))",
                "left" => $"{baseScrollCommand}.setAsHorizontalList().scrollForward().scrollIntoView(new UiSelector().text(\"{text}\"))",
                "Right" => $"{baseScrollCommand}.setAsHorizontalList().scrollBackward().scrollIntoView(new UiSelector().text(\"{text}\"))",
                _ => throw new ArgumentException($"Invalid scroll direction: {direction}")
            };


            var element = GetElement(MobileBy.AndroidUIAutomator(fullCommand));
            element.Click();

        }
        public void sendElement(By locator, string ele)
        {
            GetElement(locator).SendKeys(ele);
        }
        public void ScrollAndClick(string text)
        {

           var ele = GetElement(MobileBy.AndroidUIAutomator($"new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().textContains(\"{text}\"))"));
            ele.Click();
        }

        public void identifytheCheckBox(By locator)
        {

            var ele = GetElement(locator);

           if(ele.Selected)
           {
                ele.Click();
               
           }
            Console.WriteLine($"checkbox {ele}");
        }
        public void VerifyElementState(By locator, string expectedState)
        {
            var element = GetElement(locator);

            switch (expectedState.ToLower())
            {
                case "selected":
                    Assert.IsTrue(element.Selected, "Expected checkbox to be selected.");
                    break;

                case "notselected":
                    Assert.IsFalse(element.Selected, "Expected checkbox to be unselected.");
                    break;

                case "enabled":
                    Assert.IsTrue(element.Enabled, "Expected element to be enabled.");
                    break;

                case "disabled":
                    Assert.IsFalse(element.Enabled, "Expected element to be disabled.");
                    break;

                default:
                    throw new ArgumentException($"Invalid state: {expectedState}");
            }
        }
        public bool IsNotDisplayed(By locator)
        {
            try
            {
                return GetElement(locator).Displayed;
               
            }
           
            catch (NoSuchElementException)
            {
                return true;
            }
            
        }
        public void verifyCheckBox(By locator)
        {

            var ele = GetElement(locator);

            if (ele.Displayed)
            {
                Assert.IsTrue(ele.Displayed, $"checkbox is visible{ele}");

            }
            else
            {
                Assert.IsFalse(!ele.Displayed, $"checkbox is visisble {ele}");
            }

           
        }
    }
}
