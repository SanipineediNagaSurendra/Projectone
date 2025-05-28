using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System.Text.RegularExpressions;

namespace TestMultiplePlugins.Utilities
{
    public class ControlHelper
    {      
        public void ButtonClick(By Locator)
        {
            WaitForElement(Locator).Click();
        }
        public IWebElement WaitForElement(By locator, int time = 30)
        {
            var wait = new WebDriverWait(drivers._driver, TimeSpan.FromSeconds(time));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }
        public string get_text_attribute(IWebElement elements)
        {
            return elements.GetAttribute("text");
        }
        public string get_checked_attribute(IWebElement elements)
        {
            return elements.GetAttribute("checked");
        }
        public string get_content_attribute(IWebElement elements)
        {
            return elements.GetAttribute("content-desc");
        }
        public IReadOnlyCollection<IWebElement> WaitForElements(By locator)
        {
            return drivers._driver.FindElements(locator);
        }
        public void ScrollAndClick(string direction, string key)
        {
            var textMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "custom", "I have custom made hearing aids" },
                { "rechargeable", "I have rechargeable hearing aids" },
                { "replaceable", "I have replaceable battery hearing aids" },
                { "BluetoothPermissionPlugin", "BluetoothPermission.\nBluetoothPermissionPlugin" },
                { "PairingPlugin", "Pairing.\nPairingPlugin" },
                    // Can add more mappings here as needed
            };
            if (!textMap.TryGetValue(key, out string visibleText))
                throw new ArgumentException($"Unrecognized option '{key}'");
            string baseScrollCommand = "new UiScrollable(new UiSelector().scrollable(true))";
            string fullCommand = direction.ToLower() switch
            {
                "down" => $"{baseScrollCommand}.scrollIntoView(new UiSelector().textContains(\"{visibleText}\"))",
                "up" => $"{baseScrollCommand}.setAsVerticalList().scrollBackward().scrollIntoView(new UiSelector().textContains(\"{visibleText}\"))",
                "left" => $"{baseScrollCommand}.setAsHorizontalList().scrollForward().scrollIntoView(new UiSelector().textContains(\"{visibleText}\"))",
                "right" => $"{baseScrollCommand}.setAsHorizontalList().scrollBackward().scrollIntoView(new UiSelector().textContains(\"{visibleText}\"))",
                _ => throw new ArgumentException($"Invalid scroll direction: {direction}")
            };
            var element = WaitForElement(MobileBy.AndroidUIAutomator(fullCommand));
            element.Click();
        }
        public void Scroll(string direction, string key)
        {
            var textMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "custom", "I have custom made hearing aids" },
                { "rechargeable", "I have rechargeable hearing aids" },
                { "replaceable", "I have replaceable battery hearing aids" },
                { "BluetoothPermissionPlugin", "BluetoothPermission.\nBluetoothPermissionPlugin" },
                { "PairingPlugin", "Pairing.\nPairingPlugin" },
                            // Can add more mappings here as needed
            };
            if (!textMap.TryGetValue(key, out string visibleText))
                throw new ArgumentException($"Unrecognized option '{key}'");
            string baseScrollCommand = "new UiScrollable(new UiSelector().scrollable(true))";
            string fullCommand = direction.ToLower() switch
            {
                "down" => $"{baseScrollCommand}.scrollIntoView(new UiSelector().textContains(\"{visibleText}\"))",
                "up" => $"{baseScrollCommand}.setAsVerticalList().scrollBackward().scrollIntoView(new UiSelector().textContains(\"{visibleText}\"))",
                "left" => $"{baseScrollCommand}.setAsHorizontalList().scrollForward().scrollIntoView(new UiSelector().textContains(\"{visibleText}\"))",
                "right" => $"{baseScrollCommand}.setAsHorizontalList().scrollBackward().scrollIntoView(new UiSelector().textContains(\"{visibleText}\"))",
                _ => throw new ArgumentException($"Invalid scroll direction: {direction}")
            };

        }
    }
}