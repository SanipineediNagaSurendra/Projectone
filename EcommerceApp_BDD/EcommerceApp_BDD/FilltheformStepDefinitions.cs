using EcommerceApp_BDD.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace EcommerceApp_BDD
{
    [Binding]
    public class FilltheformStepDefinitions
    {
        [Given(@"user click on name textbox")]
        public void GivenUserClickOnNameTextbox()
        {
           
        }

        [When(@"user click on gender ""([^""]*)""  radiobutton")]
        public void WhenUserClickOnGenderRadiobutton(string p0)
        {
            
        }

        [When(@"user click on country ""([^""]*)"" textbox")]
        public void WhenUserClickOnCountryTextbox(string p1)
        {
           
        }

        [When(@"user click on ""([^""]*)"" button")]
        public void WhenUserClickOnButton(string p2)
        {
            DriverFactory.driver.FindElement(By.Id("com.androidsample.generalstore:id/btnLetsShop")).Click();
        }

        [Then(@"user identify the toast message")]
        public void ThenUserIdentifyTheToastMessage()
        {
            string s1 = DriverFactory.driver.FindElement(By.XPath("(//android.widget.Toast)[1]")).GetAttribute("name");
            Assert.AreEqual("Please enter your name", s1);
        }

        [When(@"user click on Add the cart item")]
        public void WhenUserClickOnAddTheCartItem()
        {
            DriverFactory.driver.FindElement(By.XPath("(//android.widget.TextView[@text = 'ADD TO CART'])[0]")).Click();
            DriverFactory.driver.FindElement(By.XPath("(//android.widget.TextView[@text = 'ADD TO CART'])[0]")).Click();


        }

        [When(@"user click on button cart")]
        public void WhenUserClickOnButtonCart()
        {

            DriverFactory.driver.FindElement(By.Id("com.androidsample.generalstore:id/appbar_btn_cart")).Click();
            WebDriverWait wait = new WebDriverWait(DriverFactory.driver, TimeSpan.FromSeconds(10));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));

        }
    }
}
    