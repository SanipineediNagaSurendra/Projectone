using FluentAssertions.Collections;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]
    public class IFrameStepDefinitions
    {
        private IWebDriver driver;
      

        public IFrameStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"user click on IFrame Link")]
        public void GivenUserClickOnIFrameLink()
        {
            driver.FindElement(By.XPath("//h1[text() = 'IFRAME']")).Click();
            Thread.Sleep(3000);
        }

        [When(@"user redirect to the IFrame Page")]
        public void WhenUserRedirectToTheIFramePage()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            
        }
        [When(@"user switch to frame with id ""([^""]*)""")]
        public void WhenUserSwitchToFrameWithId(string p0)
        {
            driver.SwitchTo().Frame(driver.FindElement(By.Id(p0)));
           
        }

        [When(@"user can select ""([^""]*)"" text")]
        public void WhenUserCanSelectText(string p0)
        {
            string str = driver.FindElement(By.XPath("//div[@class = 'thumbnail']/child::div/p")).Text;
            Console.WriteLine(str);

            string s1 = driver.FindElement(By.XPath("//div[@class = 'caption']/child::p[1]")).Text;
            Console.WriteLine(s1);

        }
        [Then(@"i should see the expected result")]
        public void ThenIShouldSeeTheExpectedResult()
        {
            var result = driver.FindElement(By.XPath("//div[@class = 'section-title']/p")).Text;
           
            Assert.AreEqual("Who Are We?", result);
           
        }






    }
}
