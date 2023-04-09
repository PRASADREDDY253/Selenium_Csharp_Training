using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _3_Locators
    {
        [Test]
        public void LocatorTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";
            driver.Manage().Window.Maximize();

            // Locators

            // 1.Id
            IWebElement fullNameEle= driver.FindElement(By.Id("userName"));
            fullNameEle.SendKeys("Sai Krishna");
            // driver.FindElement(By.Id("userName")).SendKeys("Sai");

            // 2.Name
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.Name("q")).SendKeys("Selenium");

            // 3. Class name
            driver.Url = "https://demoqa.com/text-box";
            driver.FindElement(By.ClassName("btn-primary")).Click();

            // 4.LinkText
            driver.Url = "https://demoqa.com/links";
            driver.FindElement(By.LinkText("Created")).Click();

            // 5.Partial Link Text
            driver.FindElement(By.PartialLinkText("Content")).Click();

            // 6.Tag
            //no of links in page
            var list = driver.FindElements(By.TagName("a"));
            Console.WriteLine("linl counts:"+list.Count);

            driver.Close();


        }
    }
}
