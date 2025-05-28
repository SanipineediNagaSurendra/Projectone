using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Pages
{
    public class Dummy
    {
        public ControlHelper controlHelper;
        public Dummy() 
        {
            controlHelper = new ControlHelper();
        }
        private readonly By rightOneOnly = By.XPath("//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.SearchResultListPage.HearingInstrumentSearchItemText\"]");
        By Options(string value) => By.XPath($"//android.widget.TextView[@resource-id=\"android:id/text1\" and @text='{value}']");       
        private string MFiFullyConnectedPresetPairingPluginXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.MFiFullyConnectedPage.";

            return elementName switch
            {
                "mfidesc" => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "Pair new Hearing aids" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                "Connect" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By ByXPaths(string elementName) => By.XPath(MFiFullyConnectedPresetPairingPluginXpaths(elementName));
        private string RestartDevicesPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.RestartDevicesPage.";
            return elementName switch
            {
                "Restart hearing aids" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "I have restarted them" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                "Show me how" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By byxpath(string elementName) => By.XPath(RestartDevicesPageXpaths(elementName));
        private string LeftMissingPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.LeftMissingPage.";
            return elementName switch
            {
                "Only one hearing aid found" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "BodyDescription1" => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "BodyDescription2" => $"//android.widget.TextView[@resource-id='{baseId}Body2']",
                "Connect right side only" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                "Search again" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By Xpaths(string elementName) => By.XPath(LeftMissingPageXpaths(elementName));
        private string RightMissingPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.RightMissingPage.";
            return elementName switch
            {
                "Only one hearing aid found" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "BodyDescription1" => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "BodyDescription2" => $"//android.widget.TextView[@resource-id='{baseId}Body2']",
                "Connect left side only" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                "Search again" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By xpaths(string elementName) => By.XPath(RightMissingPageXpaths(elementName));
        private string CompleteSetFoundPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.CompleteSetFoundPage.";
            return elementName switch
            {
                "Hearing aids found" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "Both found." => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "BodyDescription2" => $"//android.widget.TextView[@resource-id='{baseId}Body2']",
                "Connect" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                "Pair another device" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By XPaths(string elementName) => By.XPath(CompleteSetFoundPageXpaths(elementName));
        private string WaitingForBootPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.WaitingForBootPage.";
            return elementName switch
            {
                "Connected" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "Both found." => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "Continue" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By byxpaths(string elementName) => By.XPath(WaitingForBootPageXpaths(elementName));
        private string TrustedBondCompletedPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.TrustedBondCompletedPage.";
            return elementName switch
            {
                "Well done" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "You are all set" => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "Continue" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By XPathss(string elementName) => By.XPath(TrustedBondCompletedPageXpaths(elementName));
        private string AcceptPairingRequestPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.AcceptPairingRequestPage.";
            return elementName switch
            {
                "Please accept" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "Continue" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By xxPaths(string elementName) => By.XPath(AcceptPairingRequestPageXpaths(elementName));
  
        public void click(string value)
        {
            controlHelper.ButtonClick(ByXPaths(value));
        }
        public void clickOption(string value)
        {
            controlHelper.ButtonClick(byxpath(value));
        }
        public void clicks(string value)
        {
            controlHelper.ButtonClick(Xpaths(value));   
        }
        public void clickss(string value)
        {
            controlHelper.ButtonClick(xpaths(value));
        }
        public void clicking(string value)
        {
            controlHelper.ButtonClick(XPaths(value));
        }
        public void Clickss(string value)
        {
            controlHelper.ButtonClick(byxpaths(value));
        }
        public void waitfor(int time)
        {
            Thread.Sleep(time * 1000);
        }
        public void selectDevice()
        {
            controlHelper.ButtonClick(rightOneOnly);
        }
        public void Clicking(string value)
        {
            controlHelper.ButtonClick(XPathss(value));
        }
        public void Cliick(string value)
        {
            controlHelper.ButtonClick(Options(value));
        }
        public void clicksss(string value)
        {
            controlHelper.ButtonClick(xxPaths(value));
        }
    }
}