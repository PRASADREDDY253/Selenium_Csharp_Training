using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _28_Cookies
    {
        [Test]
        public void HeadlessTest()
        {
            // headless

            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";

            // 1.Get all the cookies and print
            GetCookies(driver);

            // 2.Add a cookies
            driver.Manage().Cookies.AddCookie(new Cookie("My_Cookie", "1234567"));
            Console.WriteLine("----------After Adding my cookie----------");
            GetCookies(driver);

            // 3. delete the cookie
            driver.Manage().Cookies.DeleteCookieNamed("My_Cookie");
            Console.WriteLine("----------After deleting my cookie----------");
            GetCookies(driver);

            // 4.delete all the cookies
            driver.Manage().Cookies.DeleteAllCookies();
            Console.WriteLine("----------After deleting all cookies----------");
            GetCookies(driver);
            driver.Quit();
        }

        private static void GetCookies(WebDriver driver)
        {
            var cookies = driver.Manage().Cookies.AllCookies;
            foreach (var cookie in cookies)
            {
                Console.WriteLine(cookie);
            }
        }
    }
}
