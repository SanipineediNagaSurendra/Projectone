using AppiumPracticeBDD.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Immutable;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace AppiumPracticeBDD.StepDefinitions
{
    [Binding]
    public class SwipeGesturesStepDefinitions
    {
        [Given(@"user click on ""([^""]*)"" button")]
        public void GivenUserClickOnButton(string p0)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='" + p0 + "']")).Click();
        }

        [When(@"user click on ""([^""]*)"" gesture")]
        public void WhenUserClickOnGesture(string p1)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc ='"+p1+"']")).Click();
        }

        [When(@"user click on ""([^""]*)"" gestures")]
        public void WhenUserClickOnGestures(string p2)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[contains(@content-desc,'" + p2 + "')]")).Click();  
        }


        [When(@"swipe the (.*)st image")]
        public void WhenSwipeTheStImage(int p3)
        {
            IWebElement firstimage = DriverFactory.driver.FindElement(By.XPath("(//android.widget.ImageView)[1]"));
            Assert.AreEqual(DriverFactory.driver.FindElement(By.XPath("(//android.widget.ImageView)[1]")).GetAttribute("focusable"), "true");

            
                ((IJavaScriptExecutor)DriverFactory.driver).ExecuteScript("mobile: swipeGesture", new Dictionary<string, object>
                {
                { "elementId", ((RemoteWebElement)firstimage)},
                { "direction", "left" },
                { "percent", 0.75}
            });

            Thread.Sleep(3000);

           





            Assert.AreEqual(DriverFactory.driver.FindElement(By.XPath("(//android.widget.ImageView)[1]")).GetAttribute("focusable"), "false");

        }
    }
}
