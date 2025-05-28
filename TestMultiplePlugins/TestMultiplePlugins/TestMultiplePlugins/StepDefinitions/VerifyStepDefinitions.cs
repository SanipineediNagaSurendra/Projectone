using System;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Hooks;
using TestMultiplePlugins.Pages;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class VerifyStepDefinitions
    {
        public static Verify _verify = new Verify();
        [Then(@"verify '([^']*)' is displayed")]
        public void ThenVerifyIsDisplayed(string value)
        {
           _verify.verifybutton(value);
        }
        [Then(@"verify the text ""([^""]*)"" displayed")]
        public void ThenVerifyTheTextDisplayed(string text)
        {
            _verify.verifyText(text);
        }
        [Then(@"verify if the text ""([^""]*)"" is displayed")]
        public void ThenVerifyIfTheTextIsDisplayed(string value)
        {
            _verify.verify_text(value);
        }
        [Then(@"verify if the text ""([^""]*)"" is being displayed")]
        public void ThenVerifyIfTheTextIsBeingDisplayed(string text)
        {
            _verify.verifythetexts1(text);
        }
        [Then(@"Verify the text ""([^""]*)"" is seen")]
        public void ThenVerifyTheTextIsSeen(string value)
        {
            _verify.verify_the_text(value);
        }
        [Then(@"verify the texts displayed")]
        public void ThenVerifyTheTextsDisplayed()
        {
            _verify.verifythetexts();
        }
        [Then(@"verify if the option ""([^""]*)"" is displayed")]
        public void ThenVerifyIfTheOptionIsDisplayed(string value)
        {
            _verify.verifyOption(value);
        }
        [Then(@"verify if  ""([^""]*)"" is displayed")]
        public void ThenVerifyIfIsDisplayed(string value)
        {
            _verify.verifythetext(value);
        }
        [Then(@"verify  if the ""([^""]*)"" is displayed")]
        public void ThenVerifyIfTheIsDisplayed(string connect)
        {
            _verify.Verifybutton(connect);
        }
        [Then(@"verify  if ""([^""]*)"" is  displayed")]
        public void ThenVerifyIfIsDisplays(string value)
        {
            _verify.Verifybutton(value);
        }
        [Then(@"verify ""([^""]*)"" is displayed on RestartDevicesPage")]
        public void ThenVerifyIsDisplayedOnRestartDevicesPage(string value)
        {
            _verify.verifyText(value);
        }
        [Then(@"verify plugin is completed")]
        public void ThenVerifyPluginIsCompleted()
        {
            _verify.verifyoption();
        }
        [Then(@"verify '([^']*)' is displayed on EnableBluetoothPluginPage")]
        public void ThenVerifyIsDisplayedOnEnableBluetoothPluginPage(string value)
        {
            _verify.verifybodytext(value);    
        }
        [Then(@"verify ""([^""]*)"" is displayed on EnableBluetoothPluginPage")]
        public void ThenVerifyIsDisplayedOnEnableBluetoothPluginPage1(string value)
        {
            _verify.verifythebutton(value); 
        }
        [Then(@"verify ""([^""]*)"" is displayed on CompleteSetFoundPage")]
        public void ThenVerifyIsDisplayedOnCompleteSetFoundPage(string connect)
        {
            _verify.verifyoption1(connect);
        }
        [Then(@"verify ""([^""]*)"" is displayed on LeftMissingPage")]
        public void ThenThenVerifyIsDisplayedOn(string value)
        {
            _verify.verify(value);
        }
        [Then(@"verify ""([^""]*)"" is displayed on RightMissingPage")]
        public void ThenVerifyIsDisplayedOnRightMissingPage(string value)
        {
            _verify.Verifyy(value);
        }
        [Then(@"verify ""([^""]*)"" is displayed on ""([^""]*)""")]
        public void ThenThenVerifyIsDisplayedOn(string value, string pagename)
        {
            _verify.verifyoption1(value);
        }
        [Then(@"verify '([^']*)' is displayed on SearchResultListPage")]
        public void ThenVerifyIsDisplayedOnSearchResultListPage(string value)
        {
           _verify.verifyoption(value);
        }
        [Then(@"verify if the option ""([^""]*)"" is displayed on screen")]
        public void ThenVerifyIfTheOptionIsDisplayedOnScreen(string value)
        {
           _verify.verifytheoption(value);  
        }
        [Then(@"verify if the option ""([^""]*)"" is displayed on  screen")]
        public void ThenVerifyIfTheOptionIsDisplayedOnScreen1(string value)
        {
            _verify.verifytheoptionn(value);
        }
        [Then(@"verify the string ""([^""]*)"" is displayed")]
        public void ThenVerifyTheStringIsDisplayed(string value)
        {
           _verify.verifyy(value);
        }
        [Then(@"Verify the text ""([^""]*)"" is displayed")]
        public void ThenVerifyTheTextIsDisplayed(string value)
        {
            _verify.verifyyy(value);
        }
        [Then(@"verify ""([^""]*)"" is  displayed")]
        public void ThenVerifyIsDisplayed1(string value)
        {
            _verify.verification(value);
        }
        [Then(@"verify ""([^""]*)"" is displayed on ConnectionFailedPage")]
        public void ThenVerifyIsDisplayedOnConnectionFailedPage(string value)
        {
            _verify.Verifyyy(value);
        }
        [Then(@"verify ""([^""]*)""  displays on AcceptPairingRequestPage")]
        public void ThenVerifyDisplaysOnAcceptPairingRequestPage(string value)
        {
            _verify.verifyy1(value);
        }
        [Then(@"verify '([^']*)' is displayed on BondingToPhoneFailedPage")]
        public void ThenVerifyIsDisplayedOnBondingToPhoneFailedPage(string value)
        {
            _verify.verify2(value);
        }
        [Then(@"verify '([^']*)' is displays")]
        public void ThenVerifyIsDisplays(string value)
        {
            _verify.verrify(value);
        }
        [Then(@"verify ""([^""]*)"" is displayed on WaitingForBootPage")]
        public void ThenVerifyIsDisplayedOnWaitingForBootPage(string value)
        {
            _verify.veriify(value);
        }
        [Then(@"verify ""([^""]*)"" is displayed on MFiPairingGuidePage")]
        public void ThenVerifyIsDisplayedOnMFiPairingGuidePage(string value)
        {
            _verify._verify(value);
        }
        [Then(@"verify ""([^""]*)"" is displayed on DevicesNotMadeByGNPage")]
        public void ThenVerifyIsDisplayedOnDevicesNotMadeByGNPage(string value)
        {
            _verify.Verrify(value);
        }


    }
}