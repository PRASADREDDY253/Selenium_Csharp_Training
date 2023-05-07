using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _33_Dynamic_Table
    {
        [Test]
        public void DynamicWebTableTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/web-table-element.php";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // 1.Print the no of rows and cols
            var rows = driver.FindElements(By.XPath("//table[@class='dataTable']/tbody//tr"));
            Console.WriteLine("No of rows=" + rows.Count);
            var columns = driver.FindElements(By.XPath("//table[@class='dataTable']//th"));
            Console.WriteLine("No of columns=" + columns.Count);

            // 2.Print data based on specfic condition
            //Print the Company names whose price>400.0

            for (int r = 1; r <= rows.Count; r++)
            {
                string price = driver.FindElement(By.XPath("//table[@class='dataTable']/tbody/tr[" + r + "]/td[4]")).Text;
                
                if (float.Parse(price) > 400.0)
                {
                    string companyName = driver.FindElement(By.XPath("//table[@class='dataTable']/tbody/tr[" + r + "]/td[1]")).Text;
                    Console.WriteLine(companyName+":"+price);
                }
            }

            driver.Quit();
        }
    }
}
