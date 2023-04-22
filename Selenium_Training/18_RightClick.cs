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
    internal class _18_RightClick
    {
        [Test]
        public void RightClickTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/simple_context_menu.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement rightClick_Button = driver.FindElement(By.XPath("//span[@class='context-menu-one btn btn-neutral']"));

            Actions actions = new Actions(driver);

            actions.ContextClick(rightClick_Button).Perform();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[normalize-space()='Copy']")));

            driver.FindElement(By.XPath("//span[normalize-space()='Copy']")).Click();

            IAlert alert= driver.SwitchTo().Alert();
            Assert.True(alert.Text.Contains("copy"));
            alert.Accept();

            driver.Quit();

        }
    }
}
