using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBDD.Features;
using System.Collections.Immutable;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]
    public class DropDownCheckboxesStepDefinitions
    {
        private IWebDriver driver;
        public DropDownCheckboxesStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"user click on checkboxLink")]
        public void GivenUserClickOnCheckboxLink()
        {
            driver.FindElement(By.XPath("//h1[contains(text(), 'CHECKBOXE(S)')]")).Click();

        }

        [When(@"user select ""([^""]*)"" checkbox")]
        public void WhenUserSelectCheckbox(string p0)
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//label[contains(text(), '" + p0 + "')]/input[@type='checkbox']")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"selected ""([^""]*)"" checkbox should be displayed")]
        public void ThenSelectedCheckboxShouldBeDisplayed(string p0)
        {


            bool Status = driver.FindElement(By.XPath("//label[contains(text(), '" + p0 + "')]/input[@type='checkbox']")).Selected;

            Assert.IsTrue(Status, "expected value should be true");



        }

        [Given(@"user click on dropdownbuttonLink")]
        public void GivenUserClickOnDropdownbuttonLink()
        {
            driver.FindElement(By.XPath("//h1[contains(text(), 'CHECKBOXE(S)')]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"user select all the checkboxes")]
        public void WhenUserSelectAllTheCheckboxes(Table table)
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            foreach (var row in table.Rows)
            {

                string checkboxLabel = row["checkboxes"]; 
                var checkbox = driver.FindElement(By.XPath($"//label[contains(text(), '{checkboxLabel}')]/input[@type='checkbox']")); 
                if (!checkbox.Selected) 
                { 
                    checkbox.Click();
                } 
                 Console.WriteLine($"Checkbox selected: {checkboxLabel}");
            }
        }

        [Then(@"selected table should be checked")]
        public void ThenSelectedTableShouldBeChecked(Table table)
        {
            foreach (var row in table.Rows)
            {


                string checkBoxLabel = row["checkboxes"];


               bool status = driver.FindElement(By.XPath($"//label[text()='{checkBoxLabel}']//preceding-sibling::input[@type='checkbox']")).Selected;


                Assert.IsTrue(status);
                


               
               

                
                
            }
        }

    }








}
