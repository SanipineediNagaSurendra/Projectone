using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Pages
{
    public class pairingHI
    {
       public ControlHelper controlHelper;
        private readonly By button = By.XPath("//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.MFiFullyConnectedPage.PrimaryButtonText\"]");
       private readonly By Continue = By.XPath("//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.WaitingForBootPage.PrimaryButtonText\"]");           
        private readonly By ConfirmLoc = By.XPath("//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.Pairing.Pages.TrustedBondCompletedPage.Header\"]");
        public pairingHI()
        {
           
            controlHelper = new ControlHelper();
        }
        public void ConnectClick()
        {
            controlHelper.ButtonClick(button);
        }        
        public void ContinueClick()
        {
            controlHelper.ButtonClick(Continue);
        }
        public void verifyConnection()
        {
            var element = controlHelper.WaitForElement(ConfirmLoc);
            string actualText = controlHelper.get_text_attribute(element);
            Assert.AreEqual("Well done", actualText, "NOT CONNECTED");
        }
    }
}