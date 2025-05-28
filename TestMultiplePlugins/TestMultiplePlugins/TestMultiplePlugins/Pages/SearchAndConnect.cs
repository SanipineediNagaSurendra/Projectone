using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Pages
{
    public class SearchAndConnect
    {
        public ControlHelper controlHelper;
        private readonly By SearchLoc = By.XPath("//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.SearchingPage.Header\"]");
        private readonly By closeButton = By.XPath("//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.CompleteSetFoundPage.Close\"]");
        private readonly By Connect = By.XPath("//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.CompleteSetFoundPage.PrimaryButtonText\"]");
        private By options(string value) => By.XPath($"//android.widget.Button[@text='{value}']");
        public SearchAndConnect() 
        {
            controlHelper = new ControlHelper();
        }
        public void VerifySearch(string value)
        {
            var element = controlHelper.WaitForElement(SearchLoc);
            string actualText = controlHelper.get_text_attribute(element);
            Assert.IsTrue(actualText.StartsWith(value), $"SEARCH INCOMPLETE: Actual text '{actualText}' does not start with '{value}'");
        }
        public void clickConnect()
        {
            controlHelper.ButtonClick(Connect);
            Thread.Sleep(4000);
        }
        public void clickClose()
        {
            controlHelper.ButtonClick(closeButton);
        }
        public void ClickOption(string value)
        {
            controlHelper.ButtonClick(options(value));
        }
        public void VerifyOption(string value)
        {
            var element = controlHelper.WaitForElement(options(value));
            string actualText = controlHelper.get_text_attribute(element);
            Assert.AreEqual(value, actualText, "EXIT NOT FOUND");
        }
    }
}