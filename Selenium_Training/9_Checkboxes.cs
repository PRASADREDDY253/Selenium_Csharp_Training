using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V109.Network;

namespace Selenium_Training
{
    internal class _9_Checkboxes
    {
        [Test]
        public void CheckboxesTest()
        {
            // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://itera-qa.azurewebsites.net/home/automation";
            driver.Manage().Window.Maximize();
            //implicitwait -->Global wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //1.Select one check box
            var monday = driver.FindElement(By.Id("monday"));
            if(!monday.Selected)
                monday.Click();

            // 2.UnSelect one check box
            if (monday.Selected)
                monday.Click();   

            // 3.Select all checkboxes
            var list = driver.FindElements(By.XPath("//input[@class='form-check-input' and @type='checkbox']"));
           
            foreach (var element in list)
            {
                element.Click();
            }

            // 4.UnSelect all checkboxes
            foreach (var element in list)
            {
              if(element.Selected)  
                    element.Click();
            }

            // 5.Select last 2 checkboxes 1 2 3 4 5 6 7
            for (int i = list.Count-2; i < list.Count; i++)
            {
                list.ElementAt(i).Click();
            }

            // 5.UnSelect last 2 checkboxes 1 2 3 4 5 6 7
            for (int i = list.Count - 2; i < list.Count; i++)
            {
                if(list.ElementAt(i).Selected)
                    list.ElementAt(i).Click();
            }
            driver.Quit();
        }
    }
}
