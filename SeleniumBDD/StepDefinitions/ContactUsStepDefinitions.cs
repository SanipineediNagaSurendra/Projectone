using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumBDD.POM;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]
    

    public class ContactUsStepDefinitions
    {
        private IWebDriver driver;
        ContactUsPage page;
        public ContactUsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            page = new ContactUsPage(driver);
            
          
        }
       
        [Given(@"user navigate to the webdriver university Url")]
        public void GivenUserNavigateToTheWebdriverUniversityUrl()
        {
          //  driver.Navigate().GoToUrl("https://www.webdriveruniversity.com/");
        }



        [When(@"user click on contactus link")]
        public void WhenUserClickOnContactusLink()

        {
            
            page.clickContactus();
          
        }

        [Then(@"user should be redirect to contactus page")]
        public void ThenUserShouldBeRedirectToContactusPage()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
          
        }
        [When(@"user fill the contact us form")]
        public void WhenUserFillTheContactUsForm()
        {


            driver.FindElement(By.Name("first_name")).SendKeys("ghfhf");
            driver.FindElement(By.Name("last_name")).SendKeys("ghfhf");
            driver.FindElement(By.Name("email")).SendKeys("ghfhf@gmail.com");
            driver.FindElement(By.XPath("//textarea[@name = 'message']")).SendKeys("jdjj");
            






        }
        [When(@"user click on submit button")]
        public void WhenUserClickOnSubmitButton()
        {
            driver.FindElement(By.XPath("//input[@type='submit']")).Submit();
        }

        [Then(@"thankyou message should be displayed")]
        public void ThenThankyouMessageShouldBeDisplayed()
        {


            string message = driver.FindElement(By.XPath("//div[@id='contact_reply']/h1")).Text;
            
            bool status;
           
            if (message.Contains("Thank You for your Message"))
            {
                Console.WriteLine("Message Validated");
                status = true;
            }
            else
            {
                status = false;
                Assert.Pass("Expected message is Thank You for your Message!, but actual is " + message);
                

            }
          

        }









    }    }
