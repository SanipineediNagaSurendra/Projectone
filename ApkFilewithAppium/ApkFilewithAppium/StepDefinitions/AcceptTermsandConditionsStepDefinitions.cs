using ApkFilewithAppium.Drivers;
using ApkFilewithAppium.Pages;
using ApkFilewithAppium.Utitlity;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using TechTalk.SpecFlow;

namespace ApkFilewithAppium.StepDefinitions
{
    [Binding]
    public class AcceptTermsandConditionsStepDefinitions
    {
        TestMultiplePluginAppHomePage _page = new TestMultiplePluginAppHomePage(DriverFactory._driver);
        TermsandconditionspermissionPage _permisionpage = new TermsandconditionspermissionPage(DriverFactory._driver);

        [Given(@"I Launch the PluginApp")]
        public void GivenILaunchThePluginApp()
        {
            Console.WriteLine("App is already launched in Hooks class..");
        }

        [Given(@"I have not previously accepted Terms and Conditions and Privacy Policy")]
        public void GivenIHaveNotPreviouslyAcceptedTermsAndConditionsAndPrivacyPolicy()
        {
            DriverFactory._driver.ResetApp();
        }
       
        [When(@"Accept '([^']*)' flow has been started")]
        public void WhenAcceptFlowHasBeenStarted(string termsAndConditions)
        {
            _page.ClickOnHomePageElements(termsAndConditions);
        }

        [Then(@"verify Option to read '([^']*)' is '([^']*)' on '([^']*)'")]
        public void ThenVerifyOptionToReadIsOn(string element, string displayed, string page)
        {
            _permisionpage.VerifyTermsAndConditionsElement(element, displayed, page);
        }
        [Then(@"the option to accept '([^']*)'Privacy Policy' shall be presented\.")]
        public void ThenTheOptionToAcceptPrivacyPolicyShallBePresented_(string text)
        {
            _permisionpage.verifyCheckbox(text);
        }
        [When(@"I have accepted the Terms and Conditions '([^']*)' and Privacy Policy")]
        public void WhenIHaveAcceptedTheTermsAndConditionsAndPrivacyPolicy(string checkbox)
        {
            _permisionpage.checkboxclick(checkbox);
        }
        [When(@"I have accepted the '([^']*)' accept button")]
        public void WhenIHaveAcceptedTheAcceptButton(string @continue)
        {
            _permisionpage.ContinueButton(@continue);
        }
        [When(@"I have not previously accepted '([^']*)'")]
        public void WhenIHaveNotPreviouslyAccepted(string p0)
        {
            _permisionpage.VerifyTermsNotAccepted(p0);
        }

        [When(@"the Terms and conditions of '([^']*)' is not accepted,")]
        public void WhenTheTermsAndConditionsOfIsNotAccepted(string checkbox)
        {
            _permisionpage.Checkthecheckbox(checkbox);
        }

        [Then(@"the user shall not be able to proceed with using the app\.")]
        public void ThenTheUserShallNotBeAbleToProceedWithUsingTheApp_()
        {
            _permisionpage.VerifyContinuebtn();
           
        }





    }
}
