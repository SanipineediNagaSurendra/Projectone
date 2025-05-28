using ApkFilewithAppium.Drivers;
using ApkFilewithAppium.Pages;
using System;
using TechTalk.SpecFlow;

namespace ApkFilewithAppium.StepDefinitions
{
    [Binding]
    public class AboutPluginStepDefinitions
    {
        TestMultiplePluginAppHomePage _page = new TestMultiplePluginAppHomePage(DriverFactory._driver);
        Aboutpluginpermissonpage _plugin = new Aboutpluginpermissonpage(DriverFactory._driver);

        [When(@"I start '([^']*)' flow")]
        public void WhenIStartFlow(string aboutPlugin)
        {
            _page.ClickOnHomePageElements(aboutPlugin);
        }


        [Then(@"verify '([^']*)' is '([^']*)' on '([^']*)'")]
        public void ThenVerifyIsOn(string support, string displayed, string aboutPluginPage)
        {

            _plugin.VerifySupportElement(support, displayed, aboutPluginPage);

        }
        [Then(@"a link for accessing the '([^']*)' webpage is shown")]
        public void ThenALinkForAccessingTheWebpageIsShown(string p0)
        {
            _plugin.VerifySupportpageElements(p0);
        }

    }
}
