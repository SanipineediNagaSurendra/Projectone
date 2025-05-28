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
    public class pairingservice  // select configuration
    {
        public ControlHelper controlHelper;        
        private static readonly Random _random = new Random();
        private string configName;
        private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private readonly By configurationButton = By.XPath("//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.DynamicServiceProviderConfiguration.Pages.SelectConfigurationPage.PrimaryButton\"]");
        private readonly By searchBar = By.XPath("//android.widget.EditText");
        public readonly By OKbutton = By.XPath("//android.widget.Button[@text='OK']");
        By configurationOptions(string value) => By.XPath($"//android.widget.TextView[@resource-id=\"android:id/text1\" and @text='{value}']");        
        private readonly By configButton = By.XPath("//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup");
        public pairingservice()
        {          
            controlHelper = new ControlHelper();
            configName = Generate();
        }
        public void clicknewConfiguration()                              
        {
            controlHelper.ButtonClick(configurationButton); 
        }
        public void setConfiguration()   // setting configuration
        {
            //configName = Generate();
            var textbar = controlHelper.WaitForElement(searchBar);
            textbar.SendKeys(configName);
            Thread.Sleep(5000);
            controlHelper.ButtonClick(OKbutton);
        }     
        public void clickconfiguration()    // selecting configuration name
        {
            controlHelper.ButtonClick(configButton);
        }        
        public void selectConfigurationOption(string value) //Clicking edit
        {
            controlHelper.ButtonClick(configurationOptions(value));
        }
        public static string Generate(int length = 6)
        {
            var configName = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                configName.Append(_chars[_random.Next(_chars.Length)]);
            }
            return configName.ToString();
        }
    }
}