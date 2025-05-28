using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Pages
{
    public class Settings
    {
        public ControlHelper controlHelper;
        private By connectedoption = By.XPath("//android.widget.TextView[@resource-id=\"android:id/title\" and @text=\"Connected devices\"]");
        private By selectoption = By.XPath("//android.widget.TextView[@resource-id=\"android:id/title\" and @text=\"Connection preferences\"]");
        private By bluetooth = By.XPath("//android.widget.TextView[@resource-id=\"android:id/title\" and @text=\"Bluetooth\"]");
        private By switcch = By.XPath("//android.widget.Switch[@resource-id=\"android:id/switch_widget\"]");
        public Settings()
        {
            controlHelper = new ControlHelper();
        }
        public void clickConnectedDevices()
        {
            controlHelper.ButtonClick(connectedoption);
        }
        public void clickConnectpreference()
        {
            controlHelper.ButtonClick(selectoption);
        }
        public void clickBluetooth()
        {
            controlHelper.ButtonClick(bluetooth);
        }
        public void TurnBlurtooth(string toggleOption)
        {
            switch (toggleOption.Trim().ToLower())
            {
                case "on":
                    IWebElement bluetoothSwitch = controlHelper.WaitForElement(switcch);
                    string switchStatus = bluetoothSwitch.GetAttribute("checked");
                    bool isChecked = switchStatus != null && switchStatus.Equals("true", StringComparison.OrdinalIgnoreCase);
                    if (!isChecked)
                    {
                        bluetoothSwitch.Click();
                    }
                    break;
                case "off":
                    IWebElement bluetoothSwitch1 = controlHelper.WaitForElement(switcch);
                    string switchStatuss = bluetoothSwitch1.GetAttribute("checked");
                    bool isCheckedd = switchStatuss != null && switchStatuss.Equals("true", StringComparison.OrdinalIgnoreCase);
                    if (isCheckedd)
                    {
                        bluetoothSwitch1.Click();
                    }
                    break;
                default:
                    throw new ArgumentException($"Unknown action : {toggleOption}");
            }
        }
    }    
}