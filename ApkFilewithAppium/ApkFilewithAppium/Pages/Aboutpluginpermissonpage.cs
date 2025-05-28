using ApkFilewithAppium.Utitlity;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkFilewithAppium.Pages
{
    public class Aboutpluginpermissonpage
    {
        private AppiumDriver<AndroidElement> _driver;
        private ControlHelpers _controlHelpers;
        
        public Aboutpluginpermissonpage(AppiumDriver<AndroidElement>driver) 
        {
            _driver = driver;
            _controlHelpers = new ControlHelpers(_driver);
        }
        protected By SupportpageElement(string element) => By.XPath($"//android.widget.TextView[text(), '{element}']");
        public void VerifySupportElement(string value, string status, string page)
        {
            _controlHelpers.VerifyelementisDispalyed(value, status, page);
        }
        public void VerifySupportpageElements(string value)
        {
           var ele =  _controlHelpers.GetElement(SupportpageElement(value));
            if(ele.Displayed)
            {
                
                Assert.IsTrue(ele.Displayed, $"link is not displayed {ele}");
            }
            else
            {
                Assert.IsFalse(ele.Displayed, $"link is displayed {ele}");
            }
        }
    }
}
