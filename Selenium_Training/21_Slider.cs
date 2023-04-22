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
    internal class _21_Slider
    {
        [Test]
        public void DoubleClickTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.jqueryscript.net/demo/Price-Range-Slider-jQuery-UI/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement left_handle = driver.FindElement(By.XPath("//span[1]"));
            IWebElement right_handle = driver.FindElement(By.XPath("//span[2]"));

            Actions actions = new Actions(driver);

            actions.DragAndDropToOffset(left_handle, 50, 0).Perform();
            actions.DragAndDropToOffset(left_handle, -40, 0).Perform();


            actions.DragAndDropToOffset(right_handle,-60,0).Perform();
            actions.DragAndDropToOffset(right_handle, 60, 0).Perform();

            driver.Quit();
        }
    }
}
