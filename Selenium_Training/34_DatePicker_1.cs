using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V109.Debugger;

namespace Selenium_Training
{
    internal class _34_DatePicker_1
    {
        
        [Test]
        public void DatePicker1Test()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://jqueryui.com/datepicker/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // Method-1---->use SendKeys()
            IWebElement frame= driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));
            driver.SwitchTo().Frame(frame);
            IWebElement datepicker= driver.FindElement(By.XPath("//input[@id='datepicker']"));
            //datepicker.SendKeys("15/05/2024");

            // Method 2 --> We can use next/previous arrows to select specifica date
            string day = "22";
            string month = "August";
            string year = "2026";
            datepicker.Click();

            // Select month and year
            while (true)
            {
                string mm = driver.FindElement(By.CssSelector(".ui-datepicker-month")).Text;
                string yyyy = driver.FindElement(By.CssSelector(".ui-datepicker-year")).Text;
                if (month == mm && year == yyyy)
                {
                    break;
                }
                else
                {
                    driver.FindElement(By.CssSelector(".ui-datepicker-next")).Click();  //Clicking on Next button
                }
            }
           
            // Select date
            var dates = driver.FindElements(By.XPath("//table//tr//a"));
            foreach (var date in dates)
            {
                if(date.Text== day)
                {
                    date.Click();
                    break;
                }
            }

            driver.Quit();
        }
    }
}
