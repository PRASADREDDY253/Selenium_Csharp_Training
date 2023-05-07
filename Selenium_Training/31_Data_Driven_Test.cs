using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    internal class _31_Data_Driven_Test
    {
        [TestCase(20, 30)]
        [TestCase(40, 90)]
        [TestCase(60, 10)]
        public void Addition(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum=" + sum);
        }

        [TestCase("10000", "10", "1", "year(s)", "Simple Interest", "11000.00")]
        [TestCase("1222", "1", "1", "year(s)", "Compounded Monthly", "1234.28")]
        public void FixedDepositCalculator(string prin,string intr,string per,string tp,string fre,string matur)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("----disable-notifications");
            WebDriver driver = new ChromeDriver(options);

            driver.Url = "https://www.moneycontrol.com/fixed-income/calculator/state-bank-of-india-sbi/fixed-deposit-calculator-SBI-BSB001.html?classic=true";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement principal = driver.FindElement(By.XPath("//input[@id='principal']"));
            IWebElement interest = driver.FindElement(By.XPath("//input[@id='interest']"));     
            IWebElement period = driver.FindElement(By.XPath("//input[@id='tenure']"));
            IWebElement days= driver.FindElement(By.XPath("//select[@id='tenurePeriod']"));
            IWebElement frequency = driver.FindElement(By.XPath("//select[@id='frequency']"));
            IWebElement calculate_Btn= driver.FindElement(By.XPath("//img[@src='https://images.moneycontrol.com/images/mf_revamp/btn_calcutate.gif']"));

            principal.SendKeys(prin);
            interest.SendKeys(intr);
            period.SendKeys(per);
            days.SendKeys(tp);
            frequency.SendKeys(fre);
            calculate_Btn.Click();

            string maturityValue= driver.FindElement(By.CssSelector("#resp_matval>strong")).Text;
            Console.WriteLine("Maturity Value=" + maturityValue);

            Assert.AreEqual(matur, maturityValue);
            driver.Quit();

        }
            
        
    }
}
