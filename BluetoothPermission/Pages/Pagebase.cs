using Reqnroll.BoDi;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BluetoothPermission.Drivers;
using BluetoothPermission.Support;
using Reqnroll;
using System.Xml.Linq;
using BluetoothPermission.Namespaces;
using OpenQA.Selenium.Support.UI;

namespace BluetoothPermission.Pages
{
    public class Pagebase
    {
      
        private ControlHelper controlHelper;
        private NAPNamespaces napnamespace;
        private PageFactory pagefactort;
        private BluetoothPermissionPluginPage BluetoothPermission;
     

        public Pagebase()
        {
            
            controlHelper = new ControlHelper();
            napnamespace = new NAPNamespaces();
            pagefactort = new PageFactory();
            BluetoothPermission = new BluetoothPermissionPluginPage();
           
        }

       
        public virtual string GetAutomationID(string elementName) => string.Empty;
        public virtual IWebElement? FindElement(string elementName) => null;


        public void ScrollAndClickElement(string direction, string pagename)
        {
            int scrollCount = 0;
            int maxScrolls = 5;
            while (scrollCount < maxScrolls)
            {
                try
                {
                    var element = drivers.driver1.FindElementByXPath($"{NAPNamespaces.MenuitemsinMenupageNamespace}.{pagename}']");
                    element.Click();
                    return; 
                }
                catch (NoSuchElementException)
                {
                    var size = drivers.driver1.Manage().Window.Size;

                    int startX = size.Width / 2;
                    int startY, endY;
                    if (direction.ToLower() == "down")
                    {
                        startY = (int)(size.Height * 0.8);
                        endY = (int)(size.Height * 0.2);
                    }
                    else if (direction.ToLower() == "up")
                    {
                        startY = (int)(size.Height * 0.2);
                        endY = (int)(size.Height * 0.8);
                    }
                    else
                    {
                        return;
                    }

                    new TouchAction(drivers.driver1) .Press(startX, startY).Wait(500).MoveTo(startX, endY).Release().Perform();
                    scrollCount++;
                }
            }
        }

        public void ScrollAndClickNearbydevices(string direction,string button, string pagename)
        {
            int scrollCount = 0;
            int maxScrolls = 5;
            while (scrollCount < maxScrolls)
            {
                try
                {
                   // var element = drivers.driver1.FindElementByXPath($"{NAPNamespaces.MenuitemsinMenupageNamespace}.{pagename}']");
                    var element = drivers.driver1.FindElementByXPath("//androidx.recyclerview.widget.RecyclerView[@resource-id=\"com.android.permissioncontroller:id/recycler_view\"]/android.widget.LinearLayout[8]/android.widget.RelativeLayout");
                    element.Click();
                    return;
                }
                catch (NoSuchElementException)
                {
                    var size = drivers.driver1.Manage().Window.Size;

                    int startX = size.Width / 2;
                    int startY, endY;
                    if (direction.ToLower() == "down")
                    {
                        startY = (int)(size.Height * 0.8);
                        endY = (int)(size.Height * 0.2);
                    }
                    else if (direction.ToLower() == "up")
                    {
                        startY = (int)(size.Height * 0.2);
                        endY = (int)(size.Height * 0.8);
                    }
                    else
                    {
                        return;
                    }

                    new TouchAction(drivers.driver1).Press(startX, startY).Wait(500).MoveTo(startX, endY).Release().Perform();
                    scrollCount++;
                }
            }
        }
        public void ValidateButton()
        {
            var okButton = drivers.driver1.FindElement(By.XPath("//android.widget.Button[@resource-id='com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.BluetoothPermission.BluetoothPermissionPlugin.Pages.AllowPermissionPage.PrimaryButtonText']"));
            if (okButton.TagName == "android.widget.Button") 
            {
                if (okButton.Displayed)
                {
                    Console.WriteLine("Test Passed: The 'Ok' button is displayed and it is a button.");
                }
                else
                {
                    throw new Exception("Test Failed: The 'Ok' button is not displayed!");
                }
            }
            else
            {
                throw new Exception("Test Failed: The element is not a button!");
            }
        }
        public void WaitForElementToBeVisible(BluetoothPermissionPluginPage page, string elementName, int timeoutInSeconds)
        {
            var automationId = page.GetAutomationID(elementName);
            var wait = new WebDriverWait(drivers.driver1, TimeSpan.FromSeconds(timeoutInSeconds));
            try
            {
                wait.Until(_ =>
                {
                    try
                    {
                        var foundElement = page.FindElement(elementName);
                        return foundElement is { Displayed: true };
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                });
            }
            catch (WebDriverTimeoutException)
            {
                throw new ($"Element '{elementName}' not found using AutomationID: '{automationId}' after waiting for {timeoutInSeconds} seconds.");
            }
        }
        public void WaitForElementToBeNotVisible(BluetoothPermissionPluginPage page, string elementName, int timeoutInSeconds)
        {
            var automationId = page.GetAutomationID(elementName);
            var wait = new WebDriverWait(drivers.driver1, TimeSpan.FromSeconds(timeoutInSeconds));
            try
            {
                wait.Until(_ =>
                {
                    try
                    {
                        var foundElement = page.FindElement(elementName);
                        return foundElement is { Displayed: false };
                    }
                    catch (NoSuchElementException)
                    {
                        return true;
                    }
                });
            }
            catch (WebDriverTimeoutException)
            {
               
                throw new($"Element '{elementName}' with AutomationID: {automationId} was still visible after waiting for {timeoutInSeconds} seconds.");
            }
        }

    }
}
