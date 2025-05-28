using Microsoft.Playwright;
using PlayWright_praticeBDD.Hooks;
using System;
using TechTalk.SpecFlow;

namespace PlayWright_praticeBDD.StepDefinitions
{
    [Binding]
    public class CartStepDefinitions
    {

        private readonly IPage _page;

        public CartStepDefinitions(Hooks1 hooks)
        {
            _page = hooks.page;
        }
        [Given(@"Selecting the random elements from the page")]
        public async Task GivenSelectingTheRandomElementsFromThePage()
        {
            await _page.GotoAsync("https://askomdch.com/store");
            Thread.Sleep(4000);
            var buttons = await _page.Locator("//a[text()='Add to cart']").AllAsync();

            if (buttons.Count == 0)
            {
                Console.WriteLine("No 'Add to Cart' buttons found.");
                return;
            }

            // Pick a random button
            Random rnd = new Random();
            int randomIndex = rnd.Next(buttons.Count);
            var randomButton = buttons[randomIndex];

            // Click the randomly selected button
            await randomButton.ClickAsync();

            Console.WriteLine($"Clicked 'Add to Cart' button at index {randomIndex}.");
        }

        [When(@"the cart button is clicked")]
        public async void WhenTheCartButtonIsClicked()
        {
            await _page.ClickAsync("//a[@class = 'cart-container']");
        }

        [Then(@"verify the items in the cart")]
        public void ThenVerifyTheItemsInTheCart()
        {
            
        }
    }
}
