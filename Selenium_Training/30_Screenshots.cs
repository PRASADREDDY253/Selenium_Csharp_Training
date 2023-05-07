using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _30_Screenshots
    {
        [Test]
        public void BootstrapDropdownTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.dummyticket.com/dummy-ticket-for-visa-application/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Screenshot screenshot=((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile("C:\\Users\\Prasad.Rondla\\Documents\\dummy2.png");

            driver.Close(); 

        }
    }
}
