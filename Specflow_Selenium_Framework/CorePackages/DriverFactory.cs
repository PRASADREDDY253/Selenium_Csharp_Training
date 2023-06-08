using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Edge;
using Specflow_Selenium_Framework.Hooks;

namespace Specflow_Selenium_Framework.CorePackages
{
    public class DriverFactory
    {
        AppSettings appSettings;
       
        public DriverFactory(AppSettings appsettings)
        {
            appSettings = appsettings;
        }
        public IWebDriver CreateDriver()
        {
            //string browser = Environment.GetEnvironmentVariable("BROWSER") ?? "CHROME";
            string browser = appSettings.BrowserType;

            switch (browser.ToUpperInvariant())
            {
                case "CHROME":
                    return new ChromeDriver();
                case "FIREFOX":
                    return new FirefoxDriver();
                case "EDGE":
                    return new EdgeDriver();
                default:
                    throw new ArgumentException($"Browser not yet implemented: {browser}");
            }
        }
    }
}
