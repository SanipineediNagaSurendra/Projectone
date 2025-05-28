using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBDD.Utility
{
    public class ControlHelpers
    {
        private IWebDriver _driver;

        public ControlHelpers(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement GetElement(By locator)
        {
            return _driver.FindElement(locator);
        }

        public void Click(By locator)
        {
           var ele =  GetElement(locator);
            ele.Click();
        }
    }
}
