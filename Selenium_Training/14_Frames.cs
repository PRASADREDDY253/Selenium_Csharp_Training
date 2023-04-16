using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _14_Frames
    {

        [Test]
        public void FramesTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.selenium.dev/selenium/docs/api/java/index.html?overview-summary.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //IWebElement frame1= driver.FindElement(By.XPath("//iframe[@title='All Packages']"));
            //driver.SwitchTo().Frame(frame1);
            driver.SwitchTo().Frame("packageListFrame");
            driver.FindElement(By.XPath("//a[normalize-space()='org.openqa.selenium']")).Click();
            driver.SwitchTo().DefaultContent();

            //IWebElement frame2=driver.FindElement(By.XPath("//iframe[@title='All classes and interfaces (except non-static nested types)']"));
            try
            {
                driver.SwitchTo().Frame("packageFrame");
                driver.FindElement(By.XPath("//span[normalize-space()='WebDriver']")).Click();
                driver.SwitchTo().DefaultContent();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            //var frame3=driver.FindElement(By.XPath("//iframe[@title='Package, class and interface descriptions']"));
            driver.SwitchTo().Frame("classFrame");
            driver.FindElement(By.XPath("//div[@class='topNav']//a[normalize-space()='Help']")).Click();
            driver.SwitchTo().DefaultContent();


            driver.Close();
        }
    }
}
