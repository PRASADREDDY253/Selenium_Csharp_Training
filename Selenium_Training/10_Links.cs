using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _10_Links
    {
        [Test]
        public void LinksTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://itera-qa.azurewebsites.net/home/automation";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // 1.Total no of links
            var links=driver.FindElements(By.TagName("a"));
            Console.WriteLine("Link count: "+links.Count);

            // 2.Display each link
            foreach (var link in links)
            {
                Console.WriteLine(link.Text);
            }

            // Internal link -Same page
            //External link- Open new tab/window
            //Broken links ->
            driver.Quit();
        }
    }
}
