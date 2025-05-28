using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]
    public class ToDoListStepDefinitions
    {
        private IWebDriver driver;

        public ToDoListStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"user navigate to the webdriver University url")]
        public void GivenUserNavigateToTheWebdriverUniversityUrl()
        {
            //driver.Url = "http://www.webdriveruniversity.com/";
        }


        [When(@"user click on the To-Do-List")]
        public void WhenUserClickOnTheTo_Do_List()
        {
            driver.FindElement(By.XPath("//h1[text() = 'TO DO LIST']")).Click();

        }

        [When(@"user delete  the ""([^""]*)""")]
        public void WhenUserDeleteThe(string buttontext)
        {
            string currentWindowHandle = driver.CurrentWindowHandle;
            // Get all window handles
            var windowHandles = driver.WindowHandles;
            // Switch to the new window
            foreach (var handle in windowHandles)
            {
                if (handle != currentWindowHandle)
                {
                    driver.SwitchTo().Window(handle); break;
                }
            }


            Actions actions = new Actions(driver);

            actions.MoveToElement(driver.FindElement(By.XPath("//li[contains(text(), '"+ buttontext + "')]")))
            .Build()
            .Perform();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//li[contains(text(), '"+ buttontext + "')]/span/i")).Click();

        }

        [Then(@"deleted option should not be visible ""([^""]*)""")]
        public void ThenDeletedOptionShouldNotBeVisible(string p0)
        {

            bool status;
            try
            {
               bool result =  driver.FindElement(By.XPath("//li[contains(text(), '" + p0 + "')]")).Displayed;
                 status = result;
            }
            catch 
            {
                status = false;
            }
            Assert.IsTrue(status, "Deleted element is Not present on the UI");

            
        }
    }
}
