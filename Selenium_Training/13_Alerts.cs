using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _13_Alerts
    {
        [Test]
        public void LinksTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/alerts";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // 1.Simple Alert
            driver.FindElement(By.Id("alertButton")).Click();
            IAlert simple_alert = driver.SwitchTo().Alert();
            Console.WriteLine("Simple Alert Text:" + simple_alert.Text);
            simple_alert.Accept();
            //driver.SwitchTo().Alert().Accept();

            //2.Confirmation ALert
            driver.FindElement(By.Id("confirmButton")).Click();
            IAlert confirm_alert = driver.SwitchTo().Alert();
            Console.WriteLine("Confirm Alert Text:" + confirm_alert.Text);
            //confirm_alert.Accept();
            confirm_alert.Dismiss();
            string confirmText = driver.FindElement(By.Id("confirmResult")).Text;
            Assert.True(confirmText.Contains("Cancel"));

            // 3.Prompt Alert
            driver.FindElement(By.Id("promtButton")).Click();
            IAlert prompt_alert = driver.SwitchTo().Alert();
            Console.WriteLine("Prompt Alert Text:" + prompt_alert.Text);
            prompt_alert.SendKeys("Sai Krishna");
            prompt_alert.Accept();
            string prompt_Text = driver.FindElement(By.Id("promptResult")).Text;
            Assert.True(prompt_Text.Contains("Sai Krishna"));


            driver.Quit();
        }

        }
}
