using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[assembly:Parallelizable(ParallelScope.Fixtures)]
namespace SpecFlow_Training
{
    [Binding]
    internal class MyHooks
    {
        private ScenarioContext _scenarioContext;
        private FeatureContext _featureContext;
        private static ExtentReports extent;
        private static ExtentHtmlReporter htmlReporter;

        public MyHooks(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
           
        }

        [BeforeTestRun] 
        public static void BeforeTestRun() 
        { 
            Console.WriteLine("Before Test Run");
            var wokingDir=Environment.CurrentDirectory;
            string projDir=Directory.GetParent(wokingDir).Parent.Parent.FullName;

            extent = new ExtentReports();
            htmlReporter = new ExtentHtmlReporter(Path.Combine(projDir,"myhtmlreport.html"));
            extent.AttachReporter(htmlReporter);
        }
        [AfterTestRun] public static void AfterTestRun() { 
            Console.WriteLine("After Test Run");
            extent.Flush();
        }

        [BeforeFeature] public static void BeforeFeature() 
        { 
            Console.WriteLine("Before Feature");
            extent.CreateTest("MyFirstTest").Log(Status.Pass, "This is a logging event for MyFirstTest, and it passed!");
        }
        [AfterFeature] public static void AfterFeature() { Console.WriteLine("After Feature"); }

        [BeforeScenario] public void BeforeScenario() { Console.WriteLine("Before Scenario"); }
        [After] public void AfterScenario() { Console.WriteLine("After Scenario"); }

        [BeforeScenarioBlock] public void BeforeScenarioBlock() => Console.WriteLine("Before ScenarioBlock");
        [AfterScenarioBlock] public void AfterScenarioBlock() => Console.WriteLine("After ScenarioBlock");

        [BeforeStep] public void BeforeStep() =>Console.WriteLine("Before Step");
        [AfterStep] public void AfterStep() => Console.WriteLine("After Step");
    }
}
