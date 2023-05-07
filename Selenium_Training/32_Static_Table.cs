using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _32_Static_Table
    {
        [Test]
        public void StaticWebTableTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://testautomationpractice.blogspot.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            // 1.Count the no of rows and columns
            var rows=driver.FindElements(By.XPath("//table[@name='BookTable']/tbody/tr"));
            Console.WriteLine("No of rows="+rows.Count);
            var columns = driver.FindElements(By.XPath("//table[@name='BookTable']//th"));
            Console.WriteLine("No of columns=" + columns.Count);

            // 2.Fetch specfic data and print
            Console.WriteLine(driver.FindElement(By.XPath("//table[@name='BookTable']//tr[4]/td[3]")).Text);

            // 3.Print all rows data
            for (int row = 2; row <= rows.Count; row++)
            {
                for (int col = 1; col <= columns.Count; col++)
                {
                    Console.Write(driver.FindElement(By.XPath("//table[@name='BookTable']//tr["+row +"]/td["+col+"]")).Text+"  ");
                }
                Console.WriteLine();
            }

            // 4.Print data based on specfic condition
            // Print the list of books whose author is Amith
            for (int r = 2; r <= rows.Count; r++)
            {
                string authorName=driver.FindElement(By.XPath("//table[@name='BookTable']//tr["+r+"]/td[2]")).Text;

                if (authorName== "Amit")
                {
                    string bookName=driver.FindElement(By.XPath("//table[@name='BookTable']//tr[" + r + "]/td[1]")).Text;
                    Console.WriteLine(authorName+":"+bookName);
                }
            }
            driver.Quit();
        }
    }
}
