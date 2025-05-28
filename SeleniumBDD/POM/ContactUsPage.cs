using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V129.DOM;
using SeleniumBDD.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBDD.POM
{
    public class ContactUsPage
    {
        private IWebDriver _driver;
        private ControlHelpers _controlHelpers;
        public ContactUsPage(IWebDriver driver)
        {
            this._driver = driver;
            _controlHelpers = new ControlHelpers(_driver);
        }

        private static By contactUsPage => By.XPath("//h1[text() = 'CONTACT US']");


        public void clickContactus()
        {
            _controlHelpers.Click(contactUsPage);
        }

    }
}
    