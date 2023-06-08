using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using Microsoft.Extensions.Configuration;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using Specflow_Selenium_Framework.CorePackages;
using Specflow_Selenium_Framework.Pages;
using TechTalk.SpecFlow;

namespace Specflow_Selenium_Framework.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        private static DriverFactory _driverFactory;
        private static AppSettings appSettings;
        public static ExtentTest _featureName;
        public static ExtentTest _currentScenarioName;
        public static ExtentReports extent;

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public Hooks(IObjectContainer objectContainer,ScenarioContext scenarioContext,FeatureContext featureContext)
        {
            _scenarioContext= scenarioContext;
            _featureContext= featureContext;
            _objectContainer = objectContainer;
            
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {          
            appSettings = new AppSettings();
            new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().Bind(appSettings);
            _driverFactory = new DriverFactory(appSettings);

            extent = new ExtentReports();
            string projDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            var htmlReporter = new ExtentHtmlReporter(Path.Combine(projDir, "myhtmlreport.html"));
            extent.AttachReporter(htmlReporter);
        }

        [BeforeScenario(Order = 0)]
        public void BeforeScenario()
        {
            _driver = _driverFactory.CreateDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs(_driver);

            //Get feature name
            _featureName=extent.CreateTest<Feature>(_featureContext.FeatureInfo.Title);
            //Get scenarioname
            _currentScenarioName=_featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
        }

        [AfterStep]
        public void AfterStep()
        {
            var stepType=_scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

            if (_scenarioContext.TestError==null)
            {
                if (stepType == "Given")
                {
                    _currentScenarioName.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                }
                else if (stepType == "When")
                {
                    _currentScenarioName.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                }
                else if (stepType == "Then")
                {
                    _currentScenarioName.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                }
                else if (stepType == "And")
                {
                    _currentScenarioName.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
                }
            }
            else if (_scenarioContext.TestError!=null)
            {
                var screenshot = _driver.TakeScreenshot().AsBase64EncodedString;
                var mediaEntity=MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot,_scenarioContext.ScenarioInfo.Title.Trim()).Build();
                if (stepType == "Given")
                {
                    _currentScenarioName.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
                }
                else if (stepType == "When")
                {
                    _currentScenarioName.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
                }
                else if (stepType == "Then")
                {
                    _currentScenarioName.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
                }
                else if (stepType == "And")
                {
                    _currentScenarioName.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
                }
            }
            else if (_scenarioContext.ScenarioExecutionStatus.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    _currentScenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    _currentScenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    _currentScenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            }


        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            _driver.Quit();
        }
        [AfterTestRun] public static void AfterTestRun()
        {
            extent.Flush();
        }
    }
}