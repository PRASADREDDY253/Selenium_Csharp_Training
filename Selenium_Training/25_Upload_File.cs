using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _25_Upload_File
    {
        [Test]
        public void UploadFileTest()
        {
            // Initialize the driver
           
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.foundit.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement uploadResume = driver.FindElement(By.XPath("//div[@class='heroSection-buttonContainer_secondaryBtn secondaryBtn']"));
            uploadResume.Click();

            // Type-1 -->input[type=File]
            IWebElement file = driver.FindElement(By.Id("file-upload"));
            file.SendKeys("C:\\Users\\Prasad.Rondla\\Documents\\info.pdf");

            //Type-2  -->input[type=File]
            driver.Navigate().GoToUrl("https://demo.automationtesting.in/FileUpload.html");
            IWebElement browse_brn = driver.FindElement(By.Id("input-4"));
            browse_brn.SendKeys("C:\\Users\\Prasad.Rondla\\Documents\\info.pdf");

            driver.Quit();
        }
    }
}
