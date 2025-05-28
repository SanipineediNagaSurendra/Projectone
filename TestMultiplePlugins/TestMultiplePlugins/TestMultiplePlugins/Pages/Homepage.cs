using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using static System.Net.Mime.MediaTypeNames;
using TestMultiplePlugins.Utilities;
using OpenQA.Selenium.Appium.Android;

namespace TestMultiplePlugins.Hooks
{
    public class Homepage
    {
        public ControlHelper controlHelper;
        By Options(string value) => By.XPath($"//android.widget.TextView[contains(translate(@text, 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), '{value}')]");
        public readonly By searchbar = By.XPath("//android.widget.AutoCompleteTextView[@resource-id='com.ReSound.TestMultiplePlugins:id/search_src_text']");
        public readonly By close = By.XPath("//android.widget.ImageView[@content-desc='Clear query']");
        public Homepage()
        {
            controlHelper = new ControlHelper();
        }
        public void searchForvalue(string value)
        {
            var textBox = controlHelper.WaitForElement(searchbar);                
            textBox.SendKeys(value);
            drivers._driver.HideKeyboard();
        }
        public void clickOption(string value)
        {
            controlHelper.ButtonClick(Options(value));
        }
        public void clickClose()
        {
            controlHelper.ButtonClick(close);
        }
    }
}
