using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Selenium_Framework.CorePackages
{
    public class BasePage
    {
        private readonly IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void AssertTitle(string title)
        {
            string pageTitle = _driver.Title;
            pageTitle.Should().Be(title);
        }

        public void AssertUrlContains(string url)
        {
            string pageurl = _driver.Url;
            pageurl.Should().Contain(url); 
        }
    }
}
