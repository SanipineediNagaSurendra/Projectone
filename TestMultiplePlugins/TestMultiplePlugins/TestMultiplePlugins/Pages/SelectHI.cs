using NUnit.Framework;
using OpenQA.Selenium;
using TestMultiplePlugins.Utilities;
namespace TestMultiplePlugins.Pages
{
    public class SelectHI
    {
        private By optionHeader(string value) => By.XPath($"//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.SelectRebootGuidePage.{value}CardLinkheaderText\"]");
        public ControlHelper controlHelper;
        public string displayedString;
        public SelectHI()
        {
            controlHelper = new ControlHelper();
        }
        private string SelectOption(string elementName)
        {
            return elementName switch
            {
                "RechargeableButton" => "//android.widget.Button[@resource-id='com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.SelectRebootGuidePage.RechargeableTertiaryButtonText']",
                "CustomsButton" => "//android.widget.Button[@resource-id='com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.SelectRebootGuidePage.CustomsTertiaryButtonText']",
                "ReplaceableButton" => "//android.widget.Button[@resource-id='com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.SelectRebootGuidePage.ReplaceableTertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By Select(string elementName)
        {
            return By.XPath(SelectOption(elementName));
        }
        public void gettext(string value)
        {
            var element = controlHelper.WaitForElement(optionHeader(value));
            displayedString = controlHelper.get_text_attribute(element);
        }
        public void AssertDisplayedText(string expected)
        {
            Assert.AreEqual(expected, displayedString, $"Expected: {expected} but got: {displayedString}");
        }
        public void ClickRechargeable() => controlHelper.ButtonClick(Select("RechargeableButton"));
        public void ClickCustoms() => controlHelper.ButtonClick(Select("CustomsButton"));
        public void ClickReplaceable() => controlHelper.ButtonClick(Select("ReplaceableButton"));
        public void scrollAndClick(string dir, string text)
        {
            controlHelper.ScrollAndClick(dir, text);
        }
    }
}