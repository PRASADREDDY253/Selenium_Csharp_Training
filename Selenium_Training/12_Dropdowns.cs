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
    internal class _12_Dropdowns
    {

        [Test]
        public void LinksTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://itera-qa.azurewebsites.net/home/automation";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // 1.Get the Select element
            SelectElement selectElement = new SelectElement(driver.FindElement(By.CssSelector(".custom-select")));

            // 2.Select the options in 3 ways
            selectElement.SelectByIndex(4); //Grece
            selectElement.SelectByText("Italy"); //Italy
            selectElement.SelectByValue("9");  //Denmark
            Console.WriteLine("Selected Element:"+selectElement.SelectedOption.Text);

            // 3.Capture all the options and print
            var options = selectElement.Options;
            foreach (var option in options)
            {
                Console.WriteLine(option.Text);
            }

            // 4.Select an option without using buitin methods
            //if you want to select "Turkey"
            foreach (var option in options)
            {
                if (option.Text== "Turkey")
                {
                    option.Click();
                }
            }

            driver.Quit(); 
        }
    }
}
