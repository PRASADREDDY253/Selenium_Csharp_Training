using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Selenium_Training
{
    internal class _8_Explicitwait
    {

        [Test]
        public void ExplicitWaitTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/dynamic-properties";
            driver.Manage().Window.Maximize();
            //Explicitwait -->conditional wait

            //1.Webdriverwait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //var lateBtn = wait.Until (c=> c.FindElement(By.Id("visibleAfter")));
            //{
            //    var ele = driver.FindElement(By.Id("visibleAfter"));
            //    if (ele.Displayed)
            //    {
            //        return ele;
            //    }

            //});
            

            IWebElement lateBtn = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("visibleAfter")));
            //IWebElement lateBtn = driver.FindElement(By.Id("visibleAfter"));

            Console.WriteLine("Displaed:" + lateBtn.Displayed);

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement enableBtn = wait2.Until(ExpectedConditions.ElementToBeClickable(By.Id("enableAfter")));
            //IWebElement enableBtn = driver.FindElement(By.Id("enableAfter"));
            Console.WriteLine("Enabled:" + lateBtn.Enabled);

            driver.Quit();
        }
    }
}
