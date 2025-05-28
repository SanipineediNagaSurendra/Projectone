using System;
using TechTalk.SpecFlow;

namespace SeleniumBDD.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"user is on Home page")]
        public void GivenUserIsOnHomePage()
        {
            Console.WriteLine("Given step is Called");
        }

        [When(@"user clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Console.WriteLine("When step is Called");
        }
    }
}
