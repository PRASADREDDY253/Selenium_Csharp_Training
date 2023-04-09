using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Selenium_Training
{
    public class Tests
    {
        
        [Test]
        public void BrowerCommandTest()
        {

            // Initialize the driver
            WebDriver driver = new ChromeDriver();

            //Brower Commands
            // 1.URL: ->Load a new webpage in the current browser window(Set) /Fetch the Url(Get)
            driver.Url = "https://www.google.com"; //setter
            Console.WriteLine("URL:"+driver.Url);  //getter

            // 2.Title -> Fetches the Title of the current page
            string title=driver.Title;
            Console.WriteLine("Title:"+title);

            // 3.PageSource -> Returns the source code of the page
            string pagesource=driver.PageSource;
            Console.WriteLine("page source:"+pagesource);
            
            //4 Close -->close only the current window
            // 5.Quit ->close all the windows opened by the webdriver
            //driver.Close();
            driver.Quit();
            
        }
    }
}