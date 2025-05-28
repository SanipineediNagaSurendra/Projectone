using AppiumPracticeBDD.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;

namespace AppiumPracticeBDD.StepDefinitions
{
    [Binding]
    public class Datepicker2StepDefinitions
    {
        [Given(@"user clicks on ""([^""]*)"" Button")]
        public void GivenUserClicksOnButton(string p0)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='" + p0 + "']")).Click();
        }

        [When(@"user selects on ""([^""]*)""")]
        public void WhenUserSelectsOn(string p1)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='" + p1 + "']")).Click();
        }

        [When(@"user selects on ""([^""]*)"" button")]
        public void WhenUserSelectsOnButton(string p2)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[contains(@content-desc, '" + p2 + "')]")).Click();
        }

        [When(@"user selects ""([^""]*)""")]
        public void WhenUserSelects(string p3)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.Button[text(), '" + p3 + "']")).Click();
        }

        [When(@"user selects the date ""([^""]*)""")]
        public void WhenUserSelectsTheDate(string p4)
        {
            string[] dateParts = p4.Split(' ');

           
            string year = dateParts[0];
            string month = dateParts[1];
            string day = dateParts[2];

            DriverFactory.driver.FindElement(By.Id("android:id/date_picker_header_year")).Click();

           


            ///////////////////////////

            ScrollAndClickYear(year);

            /////////////////////////////

            Thread.Sleep(2000);
            string calanderMonth = DriverFactory.driver.FindElement(By.XPath("(//android.view.View/android.view.View)[1]")).GetAttribute("content-desc");

            for (int i = 1; i < calanderMonth.Length; i++)
            {
                if (!calanderMonth.Contains(month))
                {
                    DriverFactory.driver.FindElement(By.XPath("//android.widget.ImageButton[@content-desc=\"Next month\"]")).Click();

                    Thread.Sleep(1000);
                    calanderMonth = DriverFactory.driver.FindElement(By.XPath("(//android.view.View/android.view.View)[1]")).GetAttribute("content-desc");

                }
            }

            DriverFactory.driver.FindElement(By.XPath("//android.view.View[contains(@content-desc, '" + day + "')]")).Click();
            Thread.Sleep(4000);
            DriverFactory.driver.FindElement(By.Id("android:id/button1")).Click();

        }

        public void ScrollAndClickYear(string targetYear)
        {
            
            // Locate the ListView containing the years
            var listView = DriverFactory.driver.FindElementByXPath("//android.widget.ScrollView/android.widget.ViewAnimator/android.widget.ListView");

            // Convert the target year to an integer for comparison
            int targetYearInt = int.Parse(targetYear);

            // Loop until the desired year is found
            bool isYearFound = false;
            Thread.Sleep(1000);
            while (!isYearFound)
            {
                // Get all the TextView elements within the ListView
                var years = listView.FindElementsByXPath("//android.widget.TextView");

                // Check if the desired year is visible
                foreach (var year in years)
                {
                    Thread.Sleep(500);
                    if (year.Text == targetYear)
                    {
                        // Click the desired year
                        year.Click();
                        isYearFound = true;
                        break;
                    }
                }

                // If the year is not found, scroll in the appropriate direction
                if (!isYearFound)
                {
                    Thread.Sleep(500);
                    // Get the current visible year (assuming the first visible year is the current year)
                    var currentYearElement = years[0];
                    int currentYearInt = int.Parse(currentYearElement.Text);

                    // Determine scroll direction
                    if (targetYearInt < currentYearInt)
                    {
                        Thread.Sleep(500);
                        // Scroll up if the target year is less than the current year
                        ScrollUp(listView);
                    }
                    else
                    {
                        Thread.Sleep(500);
                        // Scroll down if the target year is greater than the current year
                        ScrollDown(listView);
                    }
                }
            }
        }

        private void ScrollDown(AndroidElement element)
        {
            // Get the size and location of the element
            var size = element.Size;
            var location = element.Location;

            // Calculate the start and end points for the swipe gesture (scroll down)
            int startX = location.X + size.Width / 2;
            int startY = location.Y + size.Height - 6; // Start from the bottom
            int endX = startX;
            int endY = location.Y + 10; // Move to the top

            // Perform the swipe gesture
            TouchAction action = new TouchAction(DriverFactory.driver);
            action.Press(startX, startY).Wait(500).MoveTo(endX, endY).Release().Perform();
        }

        private void ScrollUp(AndroidElement element)
        {
            // Get the size and location of the element
            var size = element.Size;
            var location = element.Location;

            // Calculate the start and end points for the swipe gesture (scroll up)
            int startX = location.X + size.Width / 2;
            int startY = location.Y + 8; // Start from the top
            int endX = startX;
            int endY = location.Y + size.Height - 4; // Move to the bottom

            // Perform the swipe gesture
            TouchAction action = new TouchAction(DriverFactory.driver);
            action.Press(startX, startY).Wait(200).MoveTo(endX, endY).Release().Perform();
        }
    }
}
