using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _29_Bootstrap_Dropdown
    {
        [Test]
        public void BootstrapDropdownTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.dummyticket.com/dummy-ticket-for-visa-application/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement country_dropdown = driver.FindElement(By.Id("select2-billing_country-container"));
            country_dropdown.Click();
            var country_options = driver.FindElements(By.ClassName("select2-results__option"));

            foreach (var country in country_options)
            {
                if (country.Text=="Cuba")
                {
                    country.Click();
                    break;
                }
            }
            driver.Quit();

        }
    }
}
