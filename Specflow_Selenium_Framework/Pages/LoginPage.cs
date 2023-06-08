using OpenQA.Selenium;
using Specflow_Selenium_Framework.CorePackages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Selenium_Framework.Pages
{
    public class LoginPage:BasePage
    {
        private readonly IWebDriver driver;
        // Define web elements on the login page
        private IWebElement usernameField=> driver.FindElement(By.Id("user-name"));
        private IWebElement passwordField=> driver.FindElement(By.Id("password"));
        private IWebElement loginButton=> driver.FindElement(By.Id("login-button"));

        public LoginPage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
            
        }
        public void NavigateToLoginPage()
        {
            Navigate("https://www.saucedemo.com/");

        }

        public void EnterCredentials(string username, string password)
        {
            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
        }
        public void ClickLoginButton()
        {
            loginButton.Click();
        }
        
    }
}
