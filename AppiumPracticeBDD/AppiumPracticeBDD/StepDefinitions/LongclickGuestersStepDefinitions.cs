using AppiumPracticeBDD.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using TechTalk.SpecFlow;

namespace AppiumPracticeBDD.StepDefinitions
{
    [Binding]
    public class LongclickGuestersStepDefinitions
    {
        [Given(@"User click on ""([^""]*)""")]
        public void GivenUserClickOn(string p0)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='" + p0 + "']")).Click();
        }
        [When(@"user click on ""([^""]*)"" button")]
        public void WhenUserClickOnButton(string p1)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='" + p1 + "']")).Click(); 
        }
        [When(@"user clicks on ""([^""]*)""")]
        public void WhenUserClicksOn(string p2)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[contains(@content-desc, '" + p2 + "')]")).Click(); 
        }


        [When(@"user longclick on ""([^""]*)""")]
        public void WhenUserLongclickOn(string p0)
        {
            IWebElement element = DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@text='" + p0 + "']"));

            new TouchAction(DriverFactory.driver)
            .LongPress(element)
            .Release()
            .Perform();
        }
        [Then(@"should dispaly ""([^""]*)""")]
        public void ThenShouldDispaly(string p0)
        {
           string s2 =  DriverFactory.driver.FindElement(By.Id("android:id/title")).Text;

            Assert.AreEqual(s2, "Sample menu");
        }

    }
}
