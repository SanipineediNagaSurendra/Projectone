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
    public class TermsandconditionspermissionPage
    {
        private AppiumDriver<AndroidElement> _driver;
        private ControlHelpers _controlHelpers;
        public TermsandconditionspermissionPage(AppiumDriver<AndroidElement>driver) 
        {
           this._driver = driver;
            _controlHelpers = new ControlHelpers(_driver);
        }

        
        protected By Termsandconditionscontinuebtn(string element) => By.XPath("//android.widget.Button[text(), '"+element+"']"); 
        protected By TermsAndConditionsElement(string element) => By.XPath("//android.widget.TextView[contains(@text, '" + element + "')]");

        protected By TermsAndConditionsCheckbox(string element) => By.XPath("//android.view.ViewGroup[contains(@resource-id, 'Checkbox')]");

        public void VerifyTermsAndConditionsElement(string value, string status, string page)
        {
            _controlHelpers.VerifyelementisDispalyed(value, status, page);  
        }
        
        public void verifyCheckbox(string value)
        {
            
            _controlHelpers.verifyCheckBox(TermsAndConditionsCheckbox(value));
        }
        public void checkboxclick(string value)
        {
            _controlHelpers.ClickMethod(TermsAndConditionsCheckbox(value));
        }
        public void ContinueButton(string value)
        {
            _controlHelpers.ClickMethod(Termsandconditionscontinuebtn(value));
        }
        public void VerifyTermsNotAccepted(string value)
        {
            _controlHelpers.VerifyElementState(Termsandconditionscontinuebtn(value), "notselected");
        }
        public void VerifyContinuebtn()
        {
           var ele = _controlHelpers.GetElement(By.XPath("//android.widget.Button[text(), 'Continue']"));
            if(!ele.Selected)
            {
                Assert.IsTrue(!ele.Enabled, "contionue btn is not displayed");
            }
            else
            {
                Assert.IsFalse(ele.Enabled, "continue btn is displayed");
            }
        }
        public void Checkthecheckbox(string value)
        {
            _controlHelpers.identifytheCheckBox(TermsAndConditionsCheckbox(value));
        }
        
    }
}
