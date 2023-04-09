using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _7_ImplicitWait
    {
        [Test]
        public void ImplicitWaitTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/dynamic-properties";
            //driver.Manage().Window.Maximize();
            //implicitwait -->Global wait
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);

            
            IWebElement lateBtn = driver.FindElement(By.Id("visibleAfter"));

            Console.WriteLine("Displaed:"+lateBtn.Displayed);

            IWebElement enableBtn = driver.FindElement(By.Id("enableAfter"));
            Console.WriteLine("Enabled:" + lateBtn.Enabled);

            driver.Quit();
        }
    }
}
