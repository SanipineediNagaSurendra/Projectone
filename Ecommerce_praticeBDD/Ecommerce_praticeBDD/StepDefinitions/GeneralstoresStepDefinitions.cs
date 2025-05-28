using Ecommerce_praticeBDD.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using TechTalk.SpecFlow;

namespace Ecommerce_praticeBDD.StepDefinitions
{
    [Binding]
    public class GeneralstoresStepDefinitions
    {
        [Given(@"user enter the name in YourName Textbox ""([^""]*)""")]
        public void GivenUserEnterTheNameInYourNameTextbox(string name)
        {
            DriverFactory.driver.FindElement(By.ClassName("android.widget.EditText")).SendKeys(name);
        }

        [When(@"user select the country ""([^""]*)""")]
        public void WhenUserSelectTheCountry(string india)
        {
            DriverFactory.driver.FindElement(By.ClassName("android.widget.Spinner")).Click();
            DriverFactory.driver.FindElement(MobileBy.AndroidUIAutomator($"new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().text(\"{india}\"))")).Click();
        }

        [When(@"user check the Gender radio button ""([^""]*)""")]
        public void WhenUserCheckTheGenderRadioButton(string female)
        {
            DriverFactory.driver.FindElement(By.XPath("//android.widget.RadioGroup/android.widget.RadioButton[@text = '" + female + "']")).Click();
        }

        [When(@"Finally click the ""([^""]*)"" button")]
        public void WhenFinallyClickTheButton(string button)
        {
            DriverFactory.driver.FindElement(By.Id("com.ndroidsample.generalstore:id/btnLetsShop")).Click();
        }

        [Then(@"user can leave any feild in homepage identify the toast message")]
        public void ThenUserCanLeaveAnyFeildInHomepageIdentifyTheToastMessage()
        {
            //string str = DriverFactory.driver.FindElement(By.XPath("(//android.widget.Toast)[1]")).GetAttribute("name");
            //Assert.AreEqual(str, "Please enter your name" );
        }

    }
}
