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
    internal class _23_Keyboard_Actions
    {
        [Test]
        public void KeyboardActionsTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://text-compare.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement textbox1 = driver.FindElement(By.Id("inputText1"));
            IWebElement textbox2 = driver.FindElement(By.Id("inputText2"));
            textbox1.SendKeys("Sai Krishna Tej");

            Actions actions = new Actions(driver);

            // 1.Cntrl+A
            actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();

            // 2.Cntrl+C
            actions.KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Perform();

            // 3.Press Tab
            actions.KeyDown(Keys.Tab).KeyUp(Keys.Tab).Perform();

            // 4.Cntrl+V
            actions.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();

            driver.Quit();
        }
    }
}
