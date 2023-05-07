using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Training
{
    internal class _35_DatePicker2
    {
        [Test]
        public void DDatePicker2Test()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.dummyticket.com/dummy-ticket-for-visa-application/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // This date picker based on dropdowns ->SendKeys() will not work
            IWebElement departureDate= driver.FindElement(By.Id("departon"));
            //departureDate.SendKeys("01/05/2025");  //It will not work

            departureDate.Click();
            //need to use dropdowns to select month and year then click on date
            SelectElement month_dd = new SelectElement(driver.FindElement(By.CssSelector(".ui-datepicker-month")));
            month_dd.SelectByText("Dec");

            SelectElement year_dd = new SelectElement(driver.FindElement(By.CssSelector(".ui-datepicker-year")));
            year_dd.SelectByText("2023");


            // Select date
            var dates = driver.FindElements(By.XPath("//table[@class='ui-datepicker-calendar']//tr//a"));
            foreach (var date in dates)
            {
                if (date.Text == "25")
                {
                    date.Click();
                    break;
                }
            }

            
            driver.Quit();
        }
    }
}
