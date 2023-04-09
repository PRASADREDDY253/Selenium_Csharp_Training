using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _2_Navigation_Commands
    {
        [Test]
        public void NavigationTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();

            //Navigation Commands           
            driver.Url = "https://www.toolsqa.com/";

            //1.GoToUrl
            driver.Navigate().GoToUrl("https://www.google.com/");

            //2.Back
            driver.Navigate().Back(); //navigates to toolsqa

            //3.Forward
            driver.Navigate().Forward(); //Navigates to google

            // 4.Refresh
            driver.Navigate().Refresh(); //Refresh the page ->F5

            driver.Close();


        }
         
         
    }
}
