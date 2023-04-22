using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Selenium_Training
{
    internal class _22_Page_Scrolling
    {
        [Test]
        public void DoubleClickTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.countries-ofthe-world.com/flags-of-the-world.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Actions actions = new Actions(driver);
             
            //Scroll to offsets
            actions.ScrollByAmount(0, 1000).Perform();
            actions.ScrollByAmount(0, -1000).Perform();

            IWebElement india = driver.FindElement(By.XPath("//td[normalize-space()='India']"));

            //Scroll to Particular element
            //actions.ScrollToElement(india).Perform();
            IJavaScriptExecutor exec = (IJavaScriptExecutor)driver;
            exec.ExecuteScript("window.scrollBy(0,1000)");
            exec.ExecuteScript("arguments[0].scrollIntoView();", india);

            //Scroll down till end of the page
            exec.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");

            //Scroll up to top of the page
            exec.ExecuteScript("window.scrollBy(0,-document.body.scrollHeight)");

            driver.Quit();

        }
    }
}
