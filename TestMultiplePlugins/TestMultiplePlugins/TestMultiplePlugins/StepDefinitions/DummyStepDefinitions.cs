using System;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Pages;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class DummyStepDefinitions
    {
        public static Dummy _dummy = new Dummy();
        [When(@"the user clicks ""([^""]*)""")]
        public void WhenTheUserClicks(string value)
        {
            _dummy.click(value);
        }
        [When(@"I wait for ""([^""]*)"" seconds")]
        public void WhenIWaitForSeconds(int time)
        {
            _dummy.waitfor(time);
        }
        [When(@"the user press '([^']*)' on RestartDevicesPage with timeout '([^']*)'")]
        public void WhenTheUserPressOnRestartDevicesPageWithTimeout(string value,int time)
        {
            _dummy.clickOption(value);
            _dummy.waitfor(time);
        }
        [When(@"the user press '([^']*)' on RestartDevicesPage")]
        public void WhenTheUserPressOnRestartDevicesPage(string value)
        {
            _dummy.clickOption(value);
        }
        [When(@"the user clicks the option ""([^""]*)"" with the time ""([^""]*)""")]
        public void WhenTheUserClicksTheOptionWithTheTime(string value, int time)
        {
            _dummy.clickss(value);
            _dummy.waitfor(time);
        }
        [When(@"the user clicks the option ""([^""]*)"" with  the time ""([^""]*)""")]
        public void WhenTheUserClicksTheOptionWithTheTime1(string value, int time)
        {
            _dummy.clicks(value);
            _dummy.waitfor(time);
        }
        [When(@"the user selects the device")]
        public void WhenTheUserSelectsTheDevice()
        {
            _dummy.selectDevice();
        }
        [When(@"I wait '([^']*)' second")]
        public void WhenIWaitSecond(int time)
        {
            _dummy.waitfor(time);
        }
        [When(@"I click ""([^""]*)"" on CompleteSetFoundPage with timeout ""([^""]*)""")]
        public void WhenIClickOnCompleteSetFoundPageWithTimeout(string value, int p1)
        {
            _dummy.clicking(value);
            _dummy.waitfor(p1); 
        }
        [When(@"I click on ""([^""]*)"" on WaitingForBootPage with timeout ""([^""]*)""")]
        public void WhenIClickOnOnWaitingForBootPageWithTimeout(string value, int p1)
        {
            _dummy.Clickss(value);
            _dummy.waitfor(p1);
        }
        [When(@"the user clicks ""([^""]*)"" on MFiFullyConnectedPage with timeout '([^']*)'")]
        public void WhenTheUserClicksOnMFiFullyConnectedPageWithTimeout(string value, int p1)
        {
            _dummy.click(value);
            _dummy.waitfor(p1);
        }
        [When(@"I clicked on ""([^""]*)"" on TrustedBondpage")]
        public void WhenIClickedOnOnTrustedBondpage(string value)
        {
            _dummy.Clicking(value);
        }
        [When(@"the user clicks ""([^""]*)"" on AcceptPairingRequest with timeout ""([^""]*)""")]
        public void WhenTheUserClicksOnAcceptPairingRequestWithTimeout(string option, int time)
        {
            _dummy.Cliick(option);
            _dummy.waitfor(time);
        }
        [When(@"the user clicks ""([^""]*)"" on AcceptPairing request")]
        public void WhenTheUserClicksOnAcceptPairingRequest(string value)
        {
            _dummy.Cliick(value);
        }
        [When(@"the user clicks ""([^""]*)"" on AcceptPairingRequestPage")]
        public void WhenTheUserClicksOnAcceptPairingRequestPage(string value)
        {
            _dummy.clicksss(value);
        }
    }
}
