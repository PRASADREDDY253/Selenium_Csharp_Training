using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Selenium_Training
{
    internal class _11_Broken_Links
    {

        [Test]
        public void BrokenLinksTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "http://www.deadlinkcity.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // 1.Total no of links
            var links = driver.FindElements(By.TagName("a"));
            Console.WriteLine("Link count: " + links.Count);

            int valid_links=0,broken_links = 0;
            // 2.Get the href attribute(Url) of all links
            foreach (var link in links)
            {
                string url=link.GetAttribute("href");

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

                try
                {
                    var response = (HttpWebResponse)request.GetResponse();
                    if (response.StatusCode==HttpStatusCode.OK)
                    {
                        Console.WriteLine("Valid Url:" + url);
                        valid_links++;
                    }
                    
                    response.Close();
                }
                catch (WebException e)
                {
                    var errorResponse = (HttpWebResponse)e.Response;
                    Console.WriteLine("Status code: "+errorResponse.StatusCode);
                    Console.WriteLine("Broken url: " + url);
                    broken_links++;
                    errorResponse.Close();
                }
                catch(Exception e) { Console.WriteLine(e.Message); }
               
                
            }
            Console.WriteLine("Total no of valid links=" + valid_links);
            Console.WriteLine("Total no of Broken links=" + broken_links);

        }
    }
 }
