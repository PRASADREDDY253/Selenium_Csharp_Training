using NUnit.Framework;
using OpenQA.Selenium;
using Specflow_Selenium_Framework.Pages;
using System;
using TechTalk.SpecFlow;

namespace Specflow_Selenium_Framework.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage loginPage;
        
        public LoginSteps(IWebDriver driver)
        {                     
            this.loginPage = new LoginPage(driver);
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            loginPage.NavigateToLoginPage();
        }

        [When(@"I enter my (.*) and (.*)")]
        public void WhenIEnterMyUsernameAndPassword(string username,string password)
        {
            loginPage.EnterCredentials(username, password);
        }

        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            loginPage.AssertUrlContains("inventory2.html");
        }
    }
}
