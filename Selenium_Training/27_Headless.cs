using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace Selenium_Training
{
    internal class _27_Headless
    {
        [Test]
        public void HeadlessTest()
        {
            // headless
            ChromeOptions options= new ChromeOptions();
            options.AddArgument("--headless");
            WebDriver driver = new ChromeDriver(options);

            //FirefoxOptions ffoptions= new FirefoxOptions();
            //ffoptions.AddArgument("--headless");
            //WebDriver driver2 = new FirefoxDriver(ffoptions);

            //EdgeOptions edgeOptions= new EdgeOptions();
            //options.AddArgument("--headless");
            //WebDriver driver3 = new EdgeDriver(edgeOptions);

            driver.Url = "https://www.dummyticket.com/dummy-ticket-for-visa-application/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);

            driver.Quit();
        }
    }
}
