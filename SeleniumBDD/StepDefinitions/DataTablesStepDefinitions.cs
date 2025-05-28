using OpenQA.Selenium;
using System;
using System.Net.Cache;
using TechTalk.SpecFlow;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]
    public class DataTablesStepDefinitions
    {
        private IWebDriver driver;

        public DataTablesStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"user click on Data,Tables And Button states")]
        public void GivenUserClickOnDataTablesAndButtonStates()
        {
            driver.FindElement(By.XPath("//h1[text() = 'DATA, TABLES & BUTTON STATES']")).Click();

        }
        [When(@"i fetch the user details")]
        public void WhenIFetchTheUserDetails()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);




            var table = driver.FindElement(By.Id("t01"));

            var rows = table.FindElements(By.TagName("tr"));

            //for (int i = 1; i <= rows.Count-1; i++)
            //{
            //    var elements = rows[i].FindElements(By.TagName("td"));
            //    var firstname = elements[0].Text;
            //    var lastname = elements[1].Text;
            //    var age = elements[2].Text;
            //    Console.WriteLine($"Firstname: {firstname}, Lastname: {lastname}, Age: {age}");
            //}

            foreach (var row in rows)
            {
                var elements = row.FindElements(By.TagName("td"));
                if (elements.Count>0)
                {
                    var firstname = elements[0].Text;
                    var lastname = elements[1].Text;
                    var age = elements[2].Text;

                    Console.WriteLine($"Firstname: {firstname}, Lastname: {lastname}, Age: {age}");
                }
            }

        }








    }

   
}

