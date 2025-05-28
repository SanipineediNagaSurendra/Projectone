using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Pages
{
    public class ApplicationModePage
    {
        public ControlHelper controlHelper;
        private AndroidDriver<AndroidElement> _driver;        
        private readonly By continu = By.XPath("//android.widget.Button[@resource-id='com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.ManageApplicationMode.Pages.ManageApplicationModePage.PrimaryButton']");
        public ApplicationModePage()
        {

            controlHelper = new ControlHelper();
        }
        private string ManageApplicationModeXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.ManageApplicationMode.Pages.ManageApplicationModePage.";
            return elementName switch
            {
                "Is Demo Mode" => $"//android.view.ViewGroup[@resource-id='{baseId}IsDemoModeCheckbox']/android.view.ViewGroup",
                "Use Dynamic Service Provider" => $"//android.view.ViewGroup[@resource-id='{baseId}UseDynamicServiceProviderCheckbox']/android.view.ViewGroup",
                "connect" => $"//android.view.ViewGroup[@resource-id='{baseId}SelectMockWhenOpeningPluginCheckbox']/android.view.ViewGroup",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By ByXPath(string elementName) => By.XPath(ManageApplicationModeXpaths(elementName));
        public void selectoption(string elementName)
        {
            controlHelper.ButtonClick(ByXPath(elementName));        
        }        
        public void selectContinu()
        {
            controlHelper.ButtonClick(continu);
        }
    }
}
