using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _11_2_Broken_Images
    {

        [Test]
        public async Task BrokenImagesTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/broken_images";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // 1.Total no of images
            var images = driver.FindElements(By.TagName("img"));
            Console.WriteLine("Images count: " + images.Count);
            using var client = new HttpClient();
            int broken_images = 0, valid_images = 0;

            foreach (var image in images)
            {
                try
                {
                    string url = image.GetAttribute("src");
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode == false)

                    {
                        broken_images++;
                    }
                    else
                    {
                        valid_images++;
                    }

                }

                catch (Exception e) { Console.WriteLine(e.Message); }

            }
            Console.WriteLine("Total no of valid images=" + valid_images);
            Console.WriteLine("Total no of Broken images=" + broken_images);

            driver.Quit();
        }
    }
}
