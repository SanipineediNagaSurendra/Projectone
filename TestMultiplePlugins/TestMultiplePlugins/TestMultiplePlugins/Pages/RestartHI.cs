using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Pages
{
    public class RestartHI
    {    
        public ControlHelper controlHelper;
        public RestartHI()
        {
            controlHelper = new ControlHelper();
        }
        private string XpathStrings(string elementName)
        {
            return elementName switch
            {
                "RestartedButton" => "//android.widget.Button[@resource-id='com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.RestartDevicesPage.PrimaryButtonText']",
                "ShowMeHow" => "//android.widget.Button[@resource-id='com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.RestartDevicesPage.TertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By ByXPath(string elementName)
        {
            return By.XPath(XpathStrings(elementName));
        }
        public void RestartedClick()
        {
            controlHelper.ButtonClick(ByXPath("RestartedButton"));
        }
        public void ShowMeHowClick()
        {
            controlHelper.ButtonClick(ByXPath("ShowMeHow"));
        }
    }
}