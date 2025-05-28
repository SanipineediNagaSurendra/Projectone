using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using TechTalk.SpecFlow;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]

  
    public class LoginPortalStepDefinitions
    {
        private IWebDriver driver;
        public LoginPortalStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Given(@"user is on Webdriver Home Page")]
        public void GivenUserIsOnWebdriverHomePage()
        {
            //driver = new EdgeDriver();
           // driver.Manage().Window.Maximize();
            //driver.Url = "https://www.webdriveruniversity.com/";
        }

        [When(@"user click on  Login Portal")]
        public void WhenUserClickOnLoginPortal()
        {
            driver.FindElement(By.XPath("//h1[starts-with(text(), 'LOGIN')]")).Click();
        }

        [Then(@"user should be redirect to the Login Page")]
        public void ThenUserShouldBeRedirectToTheLoginPage()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
           
        }

        [When(@"user fill the Login form")]
        public void WhenUserFillTheLoginForm()
        {
            driver.FindElement(By.XPath("//input[@id = 'text']")).SendKeys("Surendra");
            driver.FindElement(By.XPath("//input[@type = 'password']")).SendKeys("Surendra@1234");
            Thread.Sleep(3000);

        }

        [When(@"user click on Login Button")]
        public void WhenUserClickonLoginButton()
        {
            driver.FindElement(By.Id("login-button")).Click();
            
        }
        
        [Then(@"it should display popup window")]

        public void ThenItShouldDisplayPopUpWindow()
        {
            string s1 = driver.SwitchTo().Alert().Text;
            Console.WriteLine(s1);

            
            
            driver.SwitchTo().Alert().Accept();
           


            








        }
        
       
        
         


       


    }
}
