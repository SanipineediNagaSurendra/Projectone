using LivingDoc.Dtos;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V85.CSS;
using System;
using System.Linq;
using System.Security.Cryptography;
using TechTalk.SpecFlow;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]
    public class AutoCompleteTextFeildStepDefinitions
    {
        private IWebDriver driver;

        public AutoCompleteTextFeildStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"user click on AutoTextFeild link")]
        public void GivenUserClickOnAutoTextFeildLink()
        {
            driver.FindElement(By.XPath("//h1[text() = 'AUTOCOMPLETE TEXTFIELD']")).Click();
            
        }

        [When(@"user search on ""([^""]*)"" named fooditems")]
        public void WhenUserSearchOnNamedFooditems(string p0)
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);

             driver.FindElement(By.XPath("//input[@type = 'text']")).SendKeys(p0);
            Thread.Sleep(5000);

        }
        [Then(@"should dispaly the ""([^""]*)"" named fooditems")]
        public void ThenShouldDispalyTheNamedFooditems(string p0)
        {

            var fooditems = driver.FindElements(By.XPath("//div[@id = 'myInputautocomplete-list']/div/input"));
            
             foreach(var item in fooditems)
             {
               string s1 =  item.GetAttribute("value");
                
                if (!s1.ToLower().StartsWith(p0))
                {
                    Assert.Fail("s1 food items should not start with gr" , p0);
                }
                





             }




        }







    }
}
