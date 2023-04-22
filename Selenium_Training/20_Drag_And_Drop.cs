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
    internal class _20_Drag_And_Drop
    {
        [Test]
        public void DoubleClickTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "http://www.dhtmlgoodies.com/scripts/drag-drop-custom/demo-drag-drop-3.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Actions actions = new Actions(driver);

            IWebElement source = driver.FindElement(By.Id("box3"));
            IWebElement target = driver.FindElement(By.Id("box103"));

            actions.DragAndDrop(source, target).Perform();

            driver.Quit();
        }
    }
}
