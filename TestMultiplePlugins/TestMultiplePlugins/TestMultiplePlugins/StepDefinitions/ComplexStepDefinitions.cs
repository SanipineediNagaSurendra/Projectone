using System;
using TechTalk.SpecFlow;
using TestMultiplePlugins.Pages;

namespace TestMultiplePlugins.StepDefinitions
{
    [Binding]
    public class ComplexStepDefinitions
    {
        public static Complex _complex = new Complex();
        [Then(@"verify ""([^""]*)"" is displayed on  ""([^""]*)""")]
        public void ThenVerifyIsDisplayedOn(string value, string pagename)
        {
            _complex.verify(value, pagename);                                   
        }
    }
}
