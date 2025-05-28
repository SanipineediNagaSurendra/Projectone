using AngleSharp.Dom;
using Appium_praticeBDD.Extent_Reports;
using Appium_praticeBDD.Pages;
using AventStack.ExtentReports;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace Appium_praticeBDD.StepDefinitions
{
    [Binding]
    public class ApiDemosAppStepDefinitions
    {
        private viewspage view = new viewspage((AndroidDriver<AndroidElement>)DriverFactory.driver);
        private Preferences preference = new Preferences((AndroidDriver<AndroidElement>)DriverFactory.driver);
        private contentpage content = new contentpage((AndroidDriver<AndroidElement>)DriverFactory.driver);
      

        [Given(@"user click on ""([^""]*)""")]
        public void GivenUserClickOn(string element1)
        {
          view.PressOneelement(element1);
        }

        [When(@"user click on ""([^""]*)""")]
        public void WhenUserClickOn(string element2)
        {
            view.PressOneelement(element2);
        }

        [When(@"user clicks on ""([^""]*)""")]
        public void WhenUserClicksOn(string p3)
        {
            view.PressOneelement(p3);
        }

        [When(@"user longpress on ""([^""]*)""")]
        public void WhenUserLongpressOn(string p4)
        {
            view.Longpress(p4);
        }

        [Then(@"user should see the popup ""([^""]*)""")]
        public void ThenUserShouldSeeThePopup(string p0)
        {
            view.VerifyElementIsDisplayed(p0);
        }

        [When(@"user swiping the image")]
        public void WhenUserSwipingTheImage()
        {
            view.swipe();
        }

        [When(@"user scroll and click on ""([^""]*)""")]
        public void WhenUserScrollAndClickOn(string element)
        {
            view.scrollGesture(element);

        }

        [When(@"user select on ""([^""]*)""")]
        public void WhenUserSelectOn(string p0)
        {
            view.scrollGesture(p0);
        }

        [When(@"user click  on Wifi checkbox")]
        public void WhenUserClickOnWifiCheckbox()
        {
            preference.Checkbox();
        }

        [When(@"user click on  ""([^""]*)""")]
        public void WhenUserclickOn(string wifi)
        {
           preference.wifisettings(wifi);
        }

        [When(@"user enter the name ""([^""]*)"" in textbox")]
        public void WhenUserEnterTheNameInTextbox(string name)
        {
           preference.EntertextBox(name);
        }

        [When(@"user click on the ""([^""]*)"" button")]
        public void WhenUserClickOnTheButton(string button)
        {
            preference.ButtonOk(button);
        }
        [Then(@"user should validate the text")]
        public void ThenUserShouldValidateTheText()
        {

            //content.getText();
        }
        [When(@"user click on the  ""([^""]*)""")]
        public void WhenUserClickOnThe(string value)
        {
            view.Date(value);
        }

        [When(@"user select the date ""([^""]*)""")]
        public void WhenUserSelectTheDate(string date)
        {
            string[] dateParts = date.Split(' ');
            

            string targetYear = dateParts[0];  // Example: "2035"
            string targetMonth = dateParts[1]; // Example: "May"
            string targetDay = dateParts[2];   // Example: "21"

            // Click the year selection button
            view.selectyear(targetYear);

            // Scroll and click the target year
            view.ScrollAndClickYear(targetYear);

            // Scroll to the correct month
            view.SelectTheMonth(targetMonth);

            // Select the correct day
            view.Day(targetDay);

            
        }
        [Then(@"should display the given date")]
        public void ThenShouldDisplayTheGivenDate()
        {

            string expecteddate = "21 May 2025";

            view.GetDate(expecteddate);

        }

    }




}


    

