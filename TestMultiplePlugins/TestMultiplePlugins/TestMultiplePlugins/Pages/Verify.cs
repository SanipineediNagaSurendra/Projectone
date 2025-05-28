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
    public class Verify
    {
        public Verify() 
        {
            controlHelper = new ControlHelper();
        }
        public ControlHelper controlHelper;
        private readonly By page = By.XPath("//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");      
        private readonly By alertHeader = By.XPath("//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/alertTitle\"]");      
        private readonly By homeoption = By.XPath("//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.StandardMenuWithPlugins.Pages.MenuPage.MenuItem.PairingPlugin\"]");      
        private readonly By settings = By.XPath("//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.RemoveMFiGuidePage.PrimaryButtonText\"]");      
        private readonly By pairnewHI = By.XPath("//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.MFiFullyConnectedPage.TertiaryButtonText\"]");
        private readonly By restartHeader = By.XPath("//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.RestartDevicesPage.Header\"]");
        string baseXPath = "//android.widget.TextView[@resource-id='com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.RemoveMFiGuidePage.StepViewItemTitleText{0}']";
        private readonly By header_1 = By.XPath("//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.MultipleNonMFiAlreadyPairedToPhoneConnectedPage.Body1\"]");
        private string MFiNotFullyConnectedPresetPairingPluginXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.MFiNotFullyConnectedPage.";
            return elementName switch
            {
                "Header" => $"//android.widget.TextView[@resource-id='{baseId}Header']",                
                "PairButton" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }    
        private By ByXPath(string elementName) => By.XPath(MFiNotFullyConnectedPresetPairingPluginXpaths(elementName));
        private string MFiFullyConnectedPresetPairingPluginXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.MFiFullyConnectedPage.";
            return elementName switch
            {
                "mfidesc" => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "pairnewHI" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                "connect" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By ByXPaths(string elementName) => By.XPath(MFiFullyConnectedPresetPairingPluginXpaths(elementName));
        private string MultipleNonMFiAlreadyPairedToPhonePluginXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.MultipleNonMFiAlreadyPairedToPhoneConnectedPage.";
            return elementName switch
            {
                "Header" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "Connect" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                "Pair new hearing aids" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By byXPath(string elementName) => By.XPath(MultipleNonMFiAlreadyPairedToPhonePluginXpaths(elementName));
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
        private string EnableBluetoothFromAppPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.EnableBluetooth.Pages.EnableBluetoothFromAppPage.";
            return elementName switch
            {
                "Turn on Bluetooth header" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "Body1Description" => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "Turn On Bluetooth" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButton']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By byxpaths(string elementName) => By.XPath(EnableBluetoothFromAppPageXpaths(elementName));
        private string RestartDevicesPageXpaths1(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.CompleteSetFoundPage.";
            return elementName switch
            {
                "Hearing aids found" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "Body1" => $"/android.widget.TextView[@resource-id='{baseId}Body1']",
                "Body2" => $"/android.widget.TextView[@resource-id='{baseId}Body2']",
                "Connect" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                "Pair another device" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By byxpathss(string elementName) => By.XPath(RestartDevicesPageXpaths1(elementName));
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
        private string SearchResultListPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.SearchResultListPage.";
            return elementName switch
            {
                "Found devices" => $"//android.widget.TextView[@resource-id='{baseId}SearchResultListHeader']",
                "Body" => $"//android.widget.TextView[@resource-id='{baseId}SearchResultListBody']",
                "Both 1" => $"android.widget.TextView[@resource-id='{baseId}HearingInstrumentSearchItemText' and @text='Both 1']",
                "Both 2" => $"android.widget.TextView[@resource-id='{baseId}HearingInstrumentSearchItemText' and @text='Both 2']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By xpaths1(string elementName) => By.XPath(SearchResultListPageXpaths(elementName));
        private string RightMissingModalPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.RightMissingModalPage.";
            return elementName switch
            {
                "Search again" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                "Use right only" => $"//android.widget.Button[@resource-id='{baseId}SecondaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT Present")
            };
        }
        private By Xpathss(string elementName) => By.XPath(RightMissingModalPageXpaths(elementName));
        private string LeftMissingModalPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.LeftMissingModalPage.";
            return elementName switch
            {
                "Search again" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                "Use right only" => $"//android.widget.Button[@resource-id='{baseId}SecondaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT Present")
            };
        }
        private By xpathss(string elementName) => By.XPath(LeftMissingModalPageXpaths(elementName));
        private string NonMFiAlreadyPairedToPhoneConnectedPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.NonMFiAlreadyPairedToPhoneConnectedPage.";
            return elementName switch
            {
                "Hearing aids found" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "“My HIs” connected to this device." => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "Body 2" => $"//android.widget.TextView[@resource-id='{baseId}Body2']",
                "Connect" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                "Pair new hearing aids" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By xpathsss(string elementName) => By.XPath(NonMFiAlreadyPairedToPhoneConnectedPageXpaths(elementName));
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
        private By XPaths(string elementName) => By.XPath(TrustedBondCompletedPageXpaths(elementName));
        private string ConnectionFailedPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.ConnectionFailedPage.";
            return elementName switch
            {
                "Connection failed" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "Try again" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                "Need more help" => $"//android.widget.Button[@resource-id='{baseId}TertiaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By XXPaths(string elementName) => By.XPath(ConnectionFailedPageXpaths(elementName));
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
        private string BondingToPhoneFailedPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.BondingToPhoneFailedPage.";
            return elementName switch
            {
                "Pairing failed" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "Body" => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "Try again" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By xxpaths(string elementName) => By.XPath(BondingToPhoneFailedPageXpaths(elementName));
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
        private By byxpathhs(string elementName) => By.XPath(WaitingForBootPageXpaths(elementName));
        private string MFiPairingGuidePageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.MFiPairingGuidePage.";
            return elementName switch
            {
                "Pair your hearing aids" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                "Open settings" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By xxPaaths(string elementName) => By.XPath(MFiPairingGuidePageXpaths(elementName));
        private string DevicesNotMadeByGNPageXpaths(string elementName)
        {
            const string baseId = "com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.DevicesNotMadeByGNPage.";
            return elementName switch
            {
                "Hearing aids not compatible" => $"//android.widget.TextView[@resource-id='{baseId}Header']",
                " not compatible" => $"//android.widget.TextView[@resource-id='{baseId}Body1']",
                "Exit" => $"//android.widget.Button[@resource-id='{baseId}PrimaryButtonText']",
                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
        private By xxPaathhs(string elementName) => By.XPath(DevicesNotMadeByGNPageXpaths(elementName));
        public void VerifyThePageIsDisplayed()
        {
            var element = controlHelper.WaitForElement(page);
            Assert.IsTrue(element.Displayed, "The page is clicked.");
        }
        public void verifyTheText(By locator,string text)
        {
            var element = controlHelper.WaitForElement(locator);
            string actualText = controlHelper.get_text_attribute(element);
            StringAssert.Contains(text, actualText, "NOT DISPLAYED");
        }
        public void verifyTheBodyText(By locator)
        {
            var element = controlHelper.WaitForElement(locator);
            string actualText = controlHelper.get_text_attribute(element);
            Assert.IsTrue(element.Displayed, "Texts is not displayed");
        }
        public void verifyallthetext()
        {
            for (int i = 1; i <= 3; i++)
            {
                var dynamicXPath = string.Format(baseXPath, i);
                var locator = By.XPath(dynamicXPath);
                var element = controlHelper.WaitForElement(locator);
                Assert.IsTrue(element.Displayed, "Texts is not displayed");
            }
        }
        public void verifytext(string text)
        {
            verifyTheText(ByXPath("Header"), text);
        }
        public void verifyButton(string text)
        {
            verifyTheText(ByXPath("PairButton"), text);
        }
        public void verifybutton(string text) 
        {
            verifyTheText(pairnewHI, text);
        }
        public void verifyText(string text)
        {
            verifyTheText(restartHeader, text);
        }
        public void verify_text(string text)
        {
            verifyTheText(ByXPaths("mfidesc"), text);
        }
        public void verifythetexts1(string text)
        {
            verifyTheText(ByXPaths("pairnewHI"), text);
        }
        public void verify_the_text(string text)
        {
           verifyTheText(ByXPaths("connect"),text);
        }
        public void verifythetexts()
        {
            verifyallthetext();
        }
        public void verifyOption(string text)
        {
            verifyTheText(settings, text);
        }
        public void verifythetext(string text)
        {            
            verifyTheText(header_1, text);
        }
        public void Verifybutton(string value)
        {
            verifyTheText(byXPath(value), value);
        }
        public void VerifyText(string value)
        {
            verifyTheText(byxpath(value), value);
        }
        public void verifyoption()
        {
            var element = controlHelper.WaitForElement(homeoption);
            Assert.IsTrue(element.Displayed, "The permission is not to be granted");
        }
        public void verifybodytext(string body)
        {
            verifyTheBodyText(byxpaths(body));
        }
        public void verifythebutton(string value)
        {
            verifyTheText(byxpaths(value), value);
        }
        public void verifyoption1(string value)
        {
            verifyTheText(byxpathss(value), value); 
        }
        public void verify(string value)
        {
            verifyTheText(Xpaths(value), value);
        }
        public void Verifyy(string value)
        {
            verifyTheText(xpaths(value), value);
        }
        public void  verifyoption(string value)
        {
            verifyTheText(xpaths1(value), value);
        }
        public void verifytheoption(string value)
        {
            verifyTheText(Xpathss(value), value);                                   
        }
        public void verifytheoptionn(string value)
        {
            verifyTheText(xpathss(value), value);                   
        }
        public void verifyy(string value) 
        {
            verifyTheText(xpathsss(value), value);
        }
        public void verifyyy(string value) 
        {
            verifyTheText(ByXPaths("mfidesc"), value);  
        }
        public void verification(string value)
        {
            verifyTheText(XPaths(value), value);
        }
        public void Verifyyy(string value)
        {
            verifyTheText(XXPaths(value), value);
        }
        public void verifyy1(string value)
        {
            verifyTheText(xxPaths(value), value);  
        }
        public void verify2(string value)
        {
            verifyTheText(xxpaths(value), value);
        }
        public void verrify(string value)
        {
            verifyTheText(alertHeader, value);
        }
        public void veriify(string value)
        {
            verifyTheText(byxpathhs(value), value);
        }
        public void _verify(string value)
        {
            verifyTheText(xxPaaths(value), value);
        }
        public void Verrify(string value)
        {
            verifyTheText(xxPaathhs(value), value);
        }
    }
}