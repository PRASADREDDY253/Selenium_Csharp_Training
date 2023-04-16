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
    internal class _17_MouseHover
    {
        [Test]
        public void MouseHoverTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.automationtesting.in/Register.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var switchToEle= driver.FindElement(By.LinkText("SwitchTo"));

            Actions actions = new Actions(driver);

            //mouse hover,right click,drag drop,double click,scrolling,key board actions
            actions.MoveToElement(switchToEle).Perform();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Alerts")));

            driver.FindElement(By.LinkText("Alerts")).Click();

            driver.Quit();
        }
    }
}
