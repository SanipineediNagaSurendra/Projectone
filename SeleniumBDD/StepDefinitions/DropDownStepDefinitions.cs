using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Cryptography;
using TechTalk.SpecFlow;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]
    public class DropDownStepDefinitions
    {
        private IWebDriver driver;

        public DropDownStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"user click on dropdownLink")]
        public void GivenUserClickOnDropdownLink()
        {
            driver.FindElement(By.XPath("//h1[contains(text(), 'DROPDOWN')]")).Click();
            Thread.Sleep(3000);
        }

        [When(@"user select the language in dropdown ""([^""]*)""")]
        public void WhenUserSelectTheLanguageInDropdown(string p0)
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            IWebElement element = driver.FindElement(By.Id("dropdowm-menu-1"));
            SelectElement selectElement = new SelectElement(element);


           
            selectElement.SelectByText(p0);
            Thread.Sleep(2000);
        }
        [Then(@"selected value ""([^""]*)"" should be displayed the language")]
        public void ThenSelectedValueShouldBeDisplayedTheLanguage(string p0)
            
        {
            IWebElement element = driver.FindElement(By.Id("dropdowm-menu-1"));
            SelectElement selectElement = new SelectElement(element);
            
            string message = selectElement.SelectedOption.Text; 
            if(message!=p0)
            {
                Assert.Fail("expected value is" + p0 + ", actual value is " + message);
            }
            
            
           

        }
        


        [When(@"user select the framework ""([^""]*)""")]
        public void WhenUserSelectTheFramework(string text)
        {
            IWebElement element1 = driver.FindElement(By.Id("dropdowm-menu-2"));
            SelectElement selectElement = new SelectElement(element1);

            selectElement.SelectByText(text);
          
        }

        [Then(@"selected value ""([^""]*)"" should be displayed on framework")]
        public void ThenSelectedValueShouldBeDisplayedOnFramework(string p0)
        {
            IWebElement element1 = driver.FindElement(By.Id("dropdowm-menu-2"));
            SelectElement selectElement = new SelectElement(element1);

            string str = selectElement.SelectedOption.Text;
            if (str == p0)
            {
                Assert.Fail("expected value is" + p0 + ", actual value is " + str);
            }
            
            
            

        }

        [When(@"user select the script ""([^""]*)""")]
        public void WhenUserSelectTheScript(string p2)
        {
            IWebElement element2 = driver.FindElement(By.Id("dropdowm-menu-3"));
            SelectElement selectelement = new SelectElement(element2);

            selectelement.SelectByText(p2);
            Thread.Sleep(3000);
           
        }

        [Then(@"selected value ""([^""]*)"" should be displayed on scripting")]
        public void ThenSelectedValueShouldBeDisplayedOnScripting(string p2)
        {
            IWebElement element2 = driver.FindElement(By.Id("dropdowm-menu-3"));
            SelectElement selectelement = new SelectElement(element2);

            string message = selectelement.SelectedOption.Text;
            if (message != p2)
            {
                Assert.Fail("Expected value is " + p2 + ", but actual value is " + message);

            }


        }

    }
}
