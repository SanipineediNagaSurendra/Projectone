using Microsoft.Playwright;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace PlayWright_praticeBDD.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IBrowserContext _context;
        

        public IPage page
        {
            get;
            private set;
        }
        [BeforeScenario]
        public async Task BeforeScenario()
        {
            _playwright =  await Playwright.CreateAsync();

            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                ExecutablePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
            }); 

            _context =  await _browser.NewContextAsync();

             page = await _context.NewPageAsync();
        }
        [AfterScenario]
        public async Task AfterScenario() 
        {
            await _browser.CloseAsync();
        }
    }
}