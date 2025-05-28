using Dynamitey;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Input;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Configuration;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]
    public class DatepickerStepDefinitions
    {
        private IWebDriver driver;
        
        public DatepickerStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"user click  on datepicker")]
        public void GivenUserClickOnDatepicker()
        {
            driver.FindElement(By.XPath("//h1[text() = 'DATEPICKER']")).Click();
            Thread.Sleep(2000);
        }

        [When(@"user select some date ""([^""]*)""")]
        public void WhenUserSelectSomeDate(string p0)
        {
            
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.ClassName("form-control")).Click();

            driver.FindElement(By.ClassName("next")).Click();
            
           


            
           




             

           
            
            
           
    
           

            Thread.Sleep(3000);
            

           
            
        }

        [Then(@"selected date should be displayed on datepicker")]
        public void ThenSelectedDateShouldBeDisplayedOnDatepicker()
        {
            
        }
    }
}
