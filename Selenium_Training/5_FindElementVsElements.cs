using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _5_FindElementVsElements
    {
        [Test]
        public void FindELementvsElementsTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/automation-practice-form";
            driver.Manage().Window.Maximize();

            //FindElemnt
            //1.On Zero Match:throws the NoSuchElement exception
            //var ele = driver.FindElement(By.Id("firstName2"));

            //2.On One match:Returns webelemnt
            var ele = driver.FindElement(By.Id("firstName"));
            ele.SendKeys("Sai");

            //3.On more than One matches: returns first element in DOM
            var ele2 = driver.FindElement(By.CssSelector(".custom-control-label"));
            Console.WriteLine("Text="+ ele2.Text); 

            //---------------------------------------------------
            //FindElemnts
            //1.On Zero Match: returns an Empty list
            var listElements = driver.FindElements(By.Id("firstName2"));

            // 2.On one match: returns list of one webelemnt only
            var listElements2 = driver.FindElements(By.Id("firstName"));

            //3.On more than One matches: returns the list of all matching elements
            var listElements3 = driver.FindElements(By.CssSelector(".custom-control-label"));

            foreach (var element in listElements3)
            {
                Console.WriteLine(element.Text);
            }
            driver.Close();
        }
    }
}
