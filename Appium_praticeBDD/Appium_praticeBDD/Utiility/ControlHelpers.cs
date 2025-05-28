using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace Appium_praticeBDD.Utiility
{
    public class ControlHelpers
    {
        private readonly AndroidDriver<AndroidElement> driver;

        public ControlHelpers(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        public void ButtonClick(By Locator)
        {
            WaitForElement(Locator).Click();
        }

        public void LongPress(By Locator)
        {
            var element = WaitForElement(Locator);
            var touchAction = new TouchAction(driver);
            touchAction.LongPress(element)
                       .Wait(2000)
                       .Release()
                       .Perform();
        }

        public void AssertElementVisible(By locator)
        {
            bool isVisible = WaitForElement(locator).Displayed;
            Assert.IsTrue(isVisible, $"Assertion Failed: Element '{locator}' is not visible.");
        }

        public void ScrollToElementAndClick(string  locator)
        {
            try
            {
                // Scroll to element using UiScrollable
                IWebElement element = driver.FindElement(MobileBy.AndroidUIAutomator(
                    $"new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().text(\"{locator}\"))"
                ));

                element.Click();
                Console.WriteLine("Element found and clicked!");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element not found after scrolling.");
            }
        }

        public void ClickCheckbox(By locator)
        {
            IWebElement ele = WaitForElement(locator);
            if (ele.GetAttribute("checked") == "true") // Check if it's checked
            {
                ele.Click(); // Uncheck it
            }
            else if (!ele.Selected)
            {
                ele.Click();
            }
        }

        public void ClickElement(By locator)
        {
            WaitForElement(locator).Click();
        }

        public void DateButton(By locator)
        {
            WaitForElement(locator).Click();
        }

        public void Text(By locator, string text)
        {
            WaitForElement(locator).SendKeys(text);
        }

        public void OK(By locator)
        {
            WaitForElement(locator).Click();
        }

        public void swiping(By locator)
        {
            IWebElement ele = WaitForElement(locator);
            ((IJavaScriptExecutor)driver).ExecuteScript("mobile: swipeGesture", new Dictionary<string, object>
            {
                { "elementId", ((RemoteWebElement)ele) },
                { "direction", "left" },
                { "percent", 0.75 }
            });
        }

        public IWebElement WaitForElement(By locator, int time = 30)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public void GetText(By locator, string expectedText)
        {
            string actualText = WaitForElement(locator).Text;
            Assert.AreEqual(expectedText, actualText, $"Text does not match. Expected: '{expectedText}', Actual: '{actualText}'");
        }

        public string get_content_attribute(IWebElement element)
        {
            return element.GetAttribute("content-desc");
        }
       

        public void day(By locator)
        {
            WaitForElement(locator).Click();
        }
        public string GetDisplayedDate(By locator)
        {
            
            return WaitForElement(locator).GetAttribute("content-desc");
        }

    }
}
