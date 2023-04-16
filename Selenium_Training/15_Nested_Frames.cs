using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V85.ApplicationCache;

namespace Selenium_Training
{
    internal class _15_Nested_Frames
    {
        [Test]
        public void NestedFramesTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.automationtesting.in/Frames.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.XPath("//a[normalize-space()='Iframe with in an Iframe']")).Click();
            //This element is inside 2 nested frames.
            IWebElement frame1 = driver.FindElement(By.XPath("//iframe[@src='MultipleFrames.html']"));
         
            //Entering the frames
            driver.SwitchTo().Frame(frame1);
            IWebElement frame2 = driver.FindElement(By.XPath("//iframe[normalize-space()='<p>Your browser does not support iframes.</p>']"));
            driver.SwitchTo().Frame(frame2);
            IWebElement textBox = driver.FindElement(By.XPath("//input[@type='text']"));
            textBox.SendKeys("sai Krishna");

            //Leaving the frames
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().DefaultContent();

            driver.FindElement(By.XPath("//a[normalize-space()='Single Iframe']")).Click();

            driver.Close();

        }
    }
}
