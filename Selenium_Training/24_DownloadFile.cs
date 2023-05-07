using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _24_DownloadFile
    {
        [Test]
        public void DownloadFileTest()
        {
            // Initialize the driver
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", "C:\\Users\\Prasad.Rondla\\Documents");

            WebDriver driver = new ChromeDriver(options);
            driver.Url = "https://demo.automationtesting.in/FileDownload.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement pdfbox = driver.FindElement(By.Id("pdfbox"));
            pdfbox.SendKeys("abcdefghij");
            IWebElement generateFile = driver.FindElement(By.Id("createPdf"));
            generateFile.Click();
            IWebElement download = driver.FindElement(By.Id("pdf-link-to-download"));
            download.Click();

            driver.Quit();
        }
    }
}
