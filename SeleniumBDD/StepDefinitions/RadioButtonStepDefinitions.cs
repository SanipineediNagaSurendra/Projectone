using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Drawing;
using TechTalk.SpecFlow;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]
    public class RadioButtonStepDefinitions
    {

        private IWebDriver driver;

        public RadioButtonStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"user click on Radiobutton Link")]
        public void GivenUserClickOnRadiobuttonLink()
        {
            driver.FindElement(By.XPath("//h1[contains(text(), 'CHECKBOXE(S)')]")).Click();
            Thread.Sleep(2000);
        }
        [When(@"user click the ""([^""]*)"" colour radiobutton")]
        public void WhenUserClickTheColourRadiobutton(string colour)
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//form[@id='radio-buttons']/input[@type='radio'][2]")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"given colour should be selected")]
        public void ThenGivenColourShouldBeSelected()
        {
            bool status =  driver.FindElement(By.XPath("//form[@id='radio-buttons']/input[@type='radio'][2]")).Selected;
            Assert.IsTrue(status, "expected value should be true");
        }
        [When(@"I get the colors of  radio buttons")]
        public void WhenIGetTheColorsOfRadioButtons()
        {
            var elements = driver.FindElements(By.XPath("//form[@id='radio-buttons']/input"));

            foreach(var element in elements)
            {

#pragma warning disable CS0618 // Type or member is obsolete
                string value = element.GetAttribute("value");
#pragma warning restore CS0618 // Type or member is obsolete



                Console.WriteLine(value);

           
            }

        }

        


    }
}
