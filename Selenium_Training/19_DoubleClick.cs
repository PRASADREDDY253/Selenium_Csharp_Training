using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Selenium_Training
{
    internal class _18_DoubletClick
    {
        [Test]
        public void DoubleClickTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/simple_context_menu.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement doubleClick_Button = driver.FindElement(By.XPath("//button[normalize-space()='Double-Click Me To See Alert']"));

            Actions actions = new Actions(driver);

            actions.DoubleClick(doubleClick_Button).Perform();
            

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.AlertIsPresent());

            IAlert alert= driver.SwitchTo().Alert();
            Assert.True(alert.Text.Contains("double clicked me"));
            alert.Accept();

            driver.Quit();

        }
    }
}
