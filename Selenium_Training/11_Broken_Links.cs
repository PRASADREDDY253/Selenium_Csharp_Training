﻿using OpenQA.Selenium.Chrome;
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
        public async Task BrokenLinksTestAsync()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/broken";      //"http://www.deadlinkcity.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // 1.Total no of links
            var links = driver.FindElements(By.TagName("a"));
            Console.WriteLine("Link count: " + links.Count);
            using var client = new HttpClient();

            int valid_links = 0, broken_links = 0;
            // 2.Get the href attribute(Url) of all links
            foreach (var link in links)
            {
                try
                {
                    string url = link.GetAttribute("href");
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode == false)

                    {
                        Console.WriteLine("Invalid Url:" + url);
                        broken_links++;
                    }
                    else
                    {
                        valid_links++;
                    }

                }

                catch (Exception e) { Console.WriteLine(e.Message); }

            }
            Console.WriteLine("Total no of valid links=" + valid_links);
            Console.WriteLine("Total no of Broken links=" + broken_links);

            driver.Quit();
        }
    }
}
