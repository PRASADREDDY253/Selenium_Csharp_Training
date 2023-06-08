using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    internal class _36_Setup_TearDown
    {
        WebDriver driver;
        [OneTimeSetUp]
        public void Onetimesetup()
        {
            Console.WriteLine("One time setup");
        }

        [OneTimeTearDown]
        public void Onetimetd()
        {
            Console.WriteLine("One time tear down");
        }

        [SetUp]
        public void Setup() {
            // Initialize the driver
             driver= new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [TearDown] 
        public void TearDown() {
            driver.Close();
        }

        [Test]
        public void SetupANdTearDownTest1()
        {
            Console.WriteLine("Title:" + driver.Title);          
        }
        [Test]
        public void SetupANdTearDownTest2()
        {
            Console.WriteLine("Url:" + driver.Url);           
        }
        [Test]
        public void SetupANdTearDownTest3()
        {
            Console.WriteLine("PageSource:" + driver.PageSource);
        }
    }
}

