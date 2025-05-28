    using Appium_praticeBDD.Utiility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium_praticeBDD.Pages
{
    public class viewspage
    {
        private readonly ControlHelpers ControlHelpers;
        private readonly AndroidDriver<AndroidElement> driver;


        public viewspage(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
            ControlHelpers = new ControlHelpers(driver);

        }

        By Locator(string value) => By.XPath("//android.widget.TextView[contains(@content-desc, '" + value + "')]");

        By element(string value) => By.XPath("//android.widget.TextView[@text = '" + value + "']");

        By locator(string value) => By.XPath("//android.widget.TextView[@resource-id=\"android:id/title\" and @text= '" + value + "']");

        By swipingele => By.XPath("//android.widget.Gallery/android.widget.ImageView[1]");

        By Datebutton(string value) => By.XPath("//android.widget.Button[text(), '\" + value + \"']");


        By year(string value) => By.XPath("//android.widget.TextView[@resource-id=\"android:id/date_picker_header_year\"]");

        private By listview => By.XPath("//android.widget.ScrollView/android.widget.ViewAnimator/android.widget.ListView");

        By clickyear(string value) => By.XPath("//android.widget.TextView[@resource-id=\"android:id/text1\" and @text= '" + value + "']");
        private readonly By current_list = By.XPath("//android.widget.TextView");

        private By nxthmnth => By.XPath("//android.widget.ImageButton[@content-desc = 'Next month']");

        public By monthview => By.XPath("//android.view.View[@resource-id='android:id/month_view']/android.view.View[1]");

        By dayview(string value) => By.XPath("//android.view.View[contains[@content-desc], '" + value + "']");

       

        public void GetDate(string value)
        {
            ControlHelpers.GetDisplayedDate(dayview(value));
        }

        public void PressOneelement(string value)
        {
            ControlHelpers.ButtonClick(Locator(value));

        }
        public void Longpress(string value)
        {
            ControlHelpers.LongPress(element(value));
        }
        public void VerifyElementIsDisplayed(string locatorText)
        {

            ControlHelpers.AssertElementVisible(locator(locatorText));
        }
        public void scrollGesture(string value)
        {
            ControlHelpers.ScrollToElementAndClick(value);
        }
        public void swipe()
        {
            ControlHelpers.swiping(swipingele);
        }
        public void Date(string value)
        {
            ControlHelpers.DateButton(Datebutton(value));
        }
        public void Day(string value)
        {
            ControlHelpers.day(dayview(value));
        }
        public void selectyear(string value)
        {
            ControlHelpers.ClickElement(year(value));
        }
        public void ScrollAndClickYear(string targetyear)
        {



            var listView = DriverFactory.driver.FindElement(listview);
            //android.widget.DatePicker[@resource-id="android:id/datePicker"]/android.widget.LinearLayout/android.widget.ScrollView
            //android.widget.ScrollView/android.widget.ViewAnimator/android.widget.ListView

            // Get the current year (assuming it's visible in the list initially)
            var currentYearElement = listView.FindElement(current_list);
            int currentYear = int.Parse(currentYearElement.Text);
            int targetYear = int.Parse(targetyear);

            // Determine scroll direction
            bool scrollDown = targetYear < currentYear;

            // Loop until the desired year is found
            bool isYearFound = false;
            while (!isYearFound)
            {
                // Get all the TextView elements within the ListView
                var textViews = listView.FindElements(current_list);

                // Check if the desired year is present in the current view
                foreach (var textView in textViews)
                {
                    if (textView.Text == targetyear)
                    {
                        // Click on the year if found
                        textView.Click();
                        isYearFound = true;
                        break;
                    }
                }

                // If the year is not found, scroll in the appropriate direction
                if (!isYearFound)
                {
                    int startX = listView.Location.X + listView.Size.Width / 2;
                    int startY, endY;

                    if (scrollDown)
                    {
                        // Scroll up: swipe from top to bottom
                        startY = listView.Location.Y + 2; // Start near the top
                        endY = listView.Location.Y + listView.Size.Height - 6; // Move to the bottom

                    }
                    else
                    {

                        // Scroll down: swipe from bottom to top
                        startY = listView.Location.Y + listView.Size.Height - 6; // Start near the bottom
                        endY = listView.Location.Y + 6; // Move to the top
                    }

                    // Perform the scroll action
                    TouchAction touchAction = new TouchAction(driver);
                    touchAction.Press(startX, startY).Wait(500).MoveTo(startX, endY).Release().Perform();
                }

            }
        }
        public void SelectTheMonth(string targetMonth)
        {

            var source = ControlHelpers.WaitForElement(monthview);
            string text = ControlHelpers.get_content_attribute(source);
            string month = text.Split(' ')[1];

            while (!month.Equals(targetMonth))
            {
                ControlHelpers.ButtonClick(nxthmnth);
                string text2 = ControlHelpers.WaitForElement(monthview).GetAttribute("content-desc");
                month = text2.Split(' ')[1];

            }
        }
        public void VerifySelectedDate(string expectedDate)
        {
            // Use ControlHelpers to get the displayed date
            string actualDate = ControlHelpers.GetDisplayedDate(dayview(expectedDate));
            if(actualDate == expectedDate)
            {
                Assert.IsTrue(expectedDate.Equals(actualDate));
            }
            else
            {
                throw new Exception("actual date is diaplayed");
            }
            // Assert that the displayed date matches the expected date
            Assert.AreEqual(expectedDate, actualDate, $"Expected date '{expectedDate}' but found '{actualDate}' on the UI.");
        }

    }
} 



    

