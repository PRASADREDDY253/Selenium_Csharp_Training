using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _26_OpenIn_New_Window
    {
        [Test]
        public void OpenInNewWindowTest()
        {
            // Initialize the driver

            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.dummyticket.com/dummy-ticket-for-visa-application/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //string key_comb = Keys.Control + Keys.Return;
            IWebElement home = driver.FindElement(By.LinkText("Home"));
            home.SendKeys(Keys.Control + Keys.Enter);

            var windows=driver.WindowHandles;

            foreach (var window in windows)
            {
                driver.SwitchTo().Window(window);
                Console.WriteLine(driver.Title);
            }

            driver.Quit();
        }
    }
}
