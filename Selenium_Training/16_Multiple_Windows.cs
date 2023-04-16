using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _16_Multiple_Windows
    {
        [Test]
        public void MultipleWindowsTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.automationtesting.in/Windows.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            string parentHandle = driver.CurrentWindowHandle;
            driver.FindElement(By.XPath("//a[@href='http://www.selenium.dev']//button[@class='btn btn-info'][normalize-space()='click']")).Click();

            var windows=driver.WindowHandles;

            foreach (var window in windows)
            {
                driver.SwitchTo().Window(window);
                Console.WriteLine(driver.Title);
                if (driver.Title== "Selenium")
                {
                    Console.WriteLine("selenium URL:"+driver.Url);
                    driver.Close();
                }
            }
            driver.SwitchTo().Window(parentHandle);
            Console.WriteLine("URL of demo site:"+driver.Url);

            driver.Quit();

        }
    }
}
