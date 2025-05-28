using AppiumPracticeBDD.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;

namespace AppiumPracticeBDD.StepDefinitions
{
    [Binding]
    public class TimerStepDefinitions
    {
        [Given(@"User select or click on ""([^""]*)""")]
        public void GivenUserSelectOrClickOn(string p0)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc= '" + p0 + "']")).Click();
        }

        [When(@"User select ""([^""]*)""")]
        public void WhenUserSelect(string p1)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[@content-desc= '" + p1 + "']")).Click();
        }


        [When(@"user click or select on ""([^""]*)"" button")]
        public void WhenUserClickOrSelectOnButton(string p2)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.TextView[contains(@content-desc, '" + p2 + "')]")).Click();
        }

        [When(@"user select or click on ""([^""]*)""")]
        public void WhenUserSelectOrClickOn(string p5)
        {

            DriverFactory.driver.FindElement(By.XPath("(//android.widget.Button[text(), '" + p5 + "'])[3]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"user Selects time  of ""([^""]*)""")]
        public void WhenUserSelectsTimeOf(string p4)
        {
            string[] inputtime = p4.Split(' ');
            string hour = inputtime[0];
            string minute = inputtime[1];
            string period = inputtime[2];

            
            ScrollAndClickHour2(hour);
            Thread.Sleep(3000);
            ScrollAndClickMinute(minute);
            Thread.Sleep(3000);
            ScrollAndClickPeriod(period);
            Thread.Sleep(3000);












        }

        public void ScrollAndClickHour2(string targetHour)
        {

            // Locate the ListView containing the years
            var listView = DriverFactory.driver.FindElementByXPath("(//android.widget.LinearLayout/android.widget.NumberPicker)[1]");

            // Convert the target year to an integer for comparison
            int targetYearInt = int.Parse(targetHour);

            // Loop until the desired year is found
            bool isYearFound = false;
            Thread.Sleep(1000);
            while (!isYearFound)
            {
                // Get all the TextView elements within the ListView
                var years = DriverFactory.driver.FindElementByXPath("(//android.widget.LinearLayout/android.widget.NumberPicker)[1]/android.widget.EditText");

                // Check if the desired year is visible
                //foreach (var year in years)
                //{
                Thread.Sleep(500);
                if (years.Text == targetHour)
                {
                    // Click the desired year
                  //  years.Click();
                    isYearFound = true;
                    break;
                }
                //   }

                // If the year is not found, scroll in the appropriate direction
                if (!isYearFound)
                {
                    Thread.Sleep(500);
                    // Get the current visible year (assuming the first visible year is the current year)
                    //var currentYearElement = years[0];
                    //int currentYearInt = int.Parse(currentYearElement.Text);

                    //// Determine scroll direction
                    //if (targetYearInt < currentYearInt)
                    //{
                    //    Thread.Sleep(500);
                    //    // Scroll up if the target year is less than the current year
                    //    ScrollUp(listView);
                    //}
                    //else
                    //{
                    //    Thread.Sleep(500);
                    //    // Scroll down if the target year is greater than the current year
                    //    ScrollDown(listView);
                    //}

                    Thread.Sleep(500);
                    ScrollDown(listView);
                }
            }
        }
        public void ScrollAndClickMinute(string targetMinute)
        {

            // Locate the ListView containing the years
            var listView = DriverFactory.driver.FindElementByXPath("(//android.widget.LinearLayout/android.widget.NumberPicker)[2]");

            // Convert the target year to an integer for comparison
            int targetYearInt = int.Parse(targetMinute);

            // Loop until the desired year is found
            bool isYearFound = false;
            Thread.Sleep(1000);
            while (!isYearFound)
            {
                // Get all the TextView elements within the ListView
                var years = DriverFactory.driver.FindElementByXPath("(//android.widget.LinearLayout/android.widget.NumberPicker)[2]/android.widget.EditText");

                // Check if the desired year is visible
                //foreach (var year in years)
                //{
                Thread.Sleep(500);
                if (years.Text == targetMinute)
                {
                    // Click the desired year
                    //  years.Click();
                    isYearFound = true;
                    break;
                }
                //   }

                // If the year is not found, scroll in the appropriate direction
                if (!isYearFound)
                {
                    Thread.Sleep(500);
                    // Get the current visible year (assuming the first visible year is the current year)
                    //var currentYearElement = years[0];
                    //int currentYearInt = int.Parse(currentYearElement.Text);

                    //// Determine scroll direction
                    //if (targetYearInt < currentYearInt)
                    //{
                    //    Thread.Sleep(500);
                    //    // Scroll up if the target year is less than the current year
                    //    ScrollUp(listView);
                    //}
                    //else
                    //{
                    //    Thread.Sleep(500);
                    //    // Scroll down if the target year is greater than the current year
                    //    ScrollDown(listView);
                    //}

                    Thread.Sleep(500);
                    ScrollDown(listView);
                }
            }
        }
        public void ScrollAndClickPeriod(string targetPeriod)
        {

            // Locate the ListView containing the years
            var listView = DriverFactory.driver.FindElementByXPath("(//android.widget.LinearLayout/android.widget.NumberPicker)[3]");

            // Convert the target year to an integer for comparison
            //int targetYearInt = int.Parse(targetPeriod);

            // Loop until the desired year is found
            bool isYearFound = false;
            Thread.Sleep(1000);
            while (!isYearFound)
            {
                // Get all the TextView elements within the ListView
                var years = DriverFactory.driver.FindElementByXPath("(//android.widget.LinearLayout/android.widget.NumberPicker)[3]/android.widget.EditText");

                // Check if the desired year is visible
                //foreach (var year in years)
                //{
                Thread.Sleep(500);
                if (years.Text == targetPeriod)
                {
                    // Click the desired year
                    //  years.Click();
                    isYearFound = true;
                    break;
                }
                //   }

                // If the year is not found, scroll in the appropriate direction
                if (!isYearFound)
                {
                    Thread.Sleep(500);
                    // Get the current visible year (assuming the first visible year is the current year)
                    //var currentYearElement = years[0];
                    //int currentYearInt = int.Parse(currentYearElement.Text);

                    //// Determine scroll direction
                    //if (targetYearInt < currentYearInt)
                    //{
                    //    Thread.Sleep(500);
                    //    // Scroll up if the target year is less than the current year
                    //    ScrollUp(listView);
                    //}
                    //else
                    //{
                    //    Thread.Sleep(500);
                    //    // Scroll down if the target year is greater than the current year
                    //    ScrollDown(listView);
                    //}

                    Thread.Sleep(500);
                    ScrollDown(listView);
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
            int startY = location.Y + size.Height -6; // Start from the bottom
            int endX = startX;
            int endY = location.Y + 3; // Move to the top

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
            int endY = location.Y + size.Height - 3; // Move to the bottom

            // Perform the swipe gesture
            TouchAction action = new TouchAction(DriverFactory.driver);
            action.Press(startX, startY).Wait(200).MoveTo(endX, endY).Release().Perform();
        }





    }
}

