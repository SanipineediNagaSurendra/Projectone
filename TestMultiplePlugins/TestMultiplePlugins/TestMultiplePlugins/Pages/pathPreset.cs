using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Pages
{
    public class pathPreset   // selecting Happypathsetup
    {
        public ControlHelper controlHelper;
        private readonly By selectPathpreset = By.XPath("//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.DynamicServiceProviderConfiguration.Pages.SelectServiceProviderPropertyPage.EditBaseButton\"]");
        private readonly By searchbarPathpreset = By.XPath("//android.widget.AutoCompleteTextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/search_src_text\"]");
        private readonly By closeButton = By.XPath("//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.DynamicServiceProviderConfiguration.Pages.SelectServiceProviderPropertyPage.CloseButton\"]");
        By Options(string value) => By.XPath($"//android.widget.TextView[contains(translate(@text, 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), '{value}')]");
        public pathPreset()
        {
            controlHelper = new ControlHelper();
        }
        public void SelectingTheOption()
        {
            controlHelper.ButtonClick(selectPathpreset);
        }
        public void searchFor(string value)
        {
            var textBox = controlHelper.WaitForElement(searchbarPathpreset);
            textBox.SendKeys(value);
            drivers._driver.HideKeyboard();
        }
        public void selectOption(string value)
        {
            controlHelper.ButtonClick(Options(value));
        }
        public void close()
        {
            controlHelper.ButtonClick(closeButton);
        }
    }
}
