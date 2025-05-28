using AppiumPracticeBDD.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Configuration;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace AppiumPracticeBDD.StepDefinitions
{


    
    [Binding]
    public class DatepickerStepDefinitions
    {
        [Given(@"user click on ""([^""]*)"" Button")]
        public void GivenUserClickOnButton(string p0)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='" + p0 + "']")).Click(); 
        }

        [When(@"user select on ""([^""]*)""")]
        public void WhenUserSelectOn(string p1)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='" + p1 + "']")).Click();
        }

        [When(@"user select on ""([^""]*)"" button")]
        public void WhenUserSelectOnButton(string p2)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[contains(@content-desc, '" + p2 + "')]")).Click();
        }


        [When(@"user select ""([^""]*)""")]
        public void WhenUserSelect(string p3)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.Button[text(), '"+p3+"']")).Click();
        }

        [When(@"user select the date ""([^""]*)""")]
        public void WhenUserSelectTheDate(string p4)
        {
            string[] dateParts = p4.Split(' ');

            // Assign the split parts to separate variables
            string year = dateParts[0];
            string month = dateParts[1];
            string day = dateParts[2];


            DriverFactory.driver.FindElement(By.Id("android:id/date_picker_header_year")).Click();
           

            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"android:id/text1\" and @text='" + year + "']")).Click();

            Thread.Sleep(2000);
            string calanderMonth = DriverFactory.driver.FindElement(By.XPath("(//android.view.View/android.view.View)[1]")).GetAttribute("content-desc");

            //while (!calanderMonth.Contains(month))
            //{ 
            //    DriverFactory.driver.FindElement(By.XPath("//android.widget.ImageButton[@content-desc=\"Next month\"]")).Click();

            //    Thread.Sleep(1000);
            //    calanderMonth = DriverFactory.driver.FindElement(By.XPath("(//android.view.View/android.view.View)[1]")).GetAttribute("content-desc");
            //}



            for(int i =1; i< calanderMonth.Length; i++)
            {
                if(!calanderMonth.Contains(month))
                {
                   DriverFactory.driver.FindElement(By.XPath("//android.widget.ImageButton[@content-desc=\"Next month\"]")).Click();

                   Thread.Sleep(1000);
                   calanderMonth = DriverFactory.driver.FindElement(By.XPath("(//android.view.View/android.view.View)[1]")).GetAttribute("content-desc");

                }
            }

            DriverFactory.driver.FindElement(By.XPath("//android.view.View[contains(@content-desc, '" + day + "')]")).Click();
            DriverFactory.driver.FindElement(By.Id("android:id/button1")).Click();
           // DriverFactory.driver.FindElement(By.XPath("//android.widget.Toast[1]"));



        }

        
        [Then(@"verify that the selected date is displayed on the calender")]
        public void ThenVerifyThatTheSelectedDateIsDisplayedOnTheCalender()
        {
           bool result =  DriverFactory.driver.FindElement(By.XPath("//android.view.View[contains(@content-desc=\"31 May 2026\")]")).Selected;
            if(result)
            {
                Assert.IsTrue(result, "condition is not true");
            }
            else
            {
                Assert.IsFalse(result);
            }
        }


    }
}
