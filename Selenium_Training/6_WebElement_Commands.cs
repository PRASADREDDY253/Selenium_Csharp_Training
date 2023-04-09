using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _7_WebElements_Commands
    {
        [Test]
        public void WebElementTest()
        {
           // Initialize the driver
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/automation-practice-form";
            driver.Manage().Window.Maximize();

            
            IWebElement firstNameEle = driver.FindElement(By.Id("firstName"));

            // 1.Sendkeys
            firstNameEle.SendKeys("Sai");

            // 2.Clear
            firstNameEle.Clear();

            // 3.Selected
            // 4.Click
            IWebElement maleRadio = driver.FindElement(By.Id("gender-radio-1"));
            bool isSelected = maleRadio.Selected;
            Console.WriteLine("Male radio before click:" + isSelected);
            if (!isSelected)
            {
                driver.FindElement(By.XPath("//label[@for='gender-radio-1']")).Click();
                //maleRadio.Click();
            }
            Console.WriteLine("Male radio after click:"+maleRadio.Selected);

            // 5.Displayed
            Console.WriteLine("Is Displayed:"+driver.FindElement(By.Id("userNumber")).Displayed);

            // 6.Enabled
            Console.WriteLine("Is Enabled:"+driver.FindElement(By.XPath("//div[contains(text(),'Select City')]")).Enabled);
            Console.WriteLine("Is Displayed:" + driver.FindElement(By.Id("userNumber")).Enabled);

            // 7.GetAttribute ->Print  -->Wele.getattribute("lang")
            Console.WriteLine("Getattribute('value')"+driver.FindElement(By.Id("dateOfBirthInput")).GetAttribute("value"));

            // 8.GetCssValue -->Print color -->ele.GetCssValue("color")
            Console.WriteLine("GetCssValue('color')" + driver.FindElement(By.Id("dateOfBirthInput")).GetCssValue("color"));

            // 9.Location
            Console.WriteLine("Location:"+ firstNameEle.Location);

            // 10.Size
            Console.WriteLine("Location:" + firstNameEle.Size);

            // 11.Text
            Console.WriteLine("Text:"+driver.FindElement(By.XPath("//label[@for='uploadPicture']")).Text);

            // 12.TagName
            Console.WriteLine("Tag name:"+firstNameEle.TagName);

            // 13.Submit
            maleRadio.Submit();

            driver.Close();
        }
    }
}
