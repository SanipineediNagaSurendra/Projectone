using AppiumPracticeBDD.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using TechTalk.SpecFlow;

namespace AppiumPracticeBDD.StepDefinitions
{
    [Binding]
    public class ScrollGesturesStepDefinitions
    {
     

        [Given(@"user click on ""([^""]*)""")]
        public void GivenUserClickOn(string p0)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='" + p0 + "']")).Click();  
        }

       // [When(@"user scroll and click on ""([^""]*)""")]
       // public void WhenUserScrollAndClickOn(string p1)zz
        //{

        //    var element=DriverFactory.driver.FindElement(MobileBy.AndroidUIAutomator($"new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().text(\"{p1}\"))"));
        //    element.Click();
            
        //}
    }
}
