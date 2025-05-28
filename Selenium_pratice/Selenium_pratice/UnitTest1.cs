using OpenQA.Selenium;
using OpenQA.Selenium.Edge;


namespace Selenium_pratice
{
    public class Tests
    {
        [Test]
        public void LaunchTheBrowser()
        {
            IWebDriver driver = new EdgeDriver();
            //Launching the Browser in selenium
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.webdriveruniversity.com/"; //set the url
            driver.FindElement(By.XPath("//h1[text() = 'CONTACT US']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//input[@name = 'first_name']")).SendKeys("Surendra");
            driver.FindElement(By.XPath("//input[@name = 'last_name']")).SendKeys("Sanipineedi");
            driver.FindElement(By.XPath("//input[@name = 'email']")).SendKeys("surendra@gmail.com");
            driver.FindElement(By.XPath("//textarea[@placeholder = 'Comments']")).SendKeys("Its working good..");
            driver.FindElement(By.XPath("//input[@type = 'submit']")).Click();
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}