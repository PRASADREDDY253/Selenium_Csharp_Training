using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow_Training.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        int firstnum, secondnum;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        ScenarioContext scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext= scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            firstnum= number;
            Console.WriteLine("first number:"+number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            secondnum= number;
            Console.WriteLine("Second number:" + number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            int result2 = firstnum + secondnum;
            Console.WriteLine("Adding two numbers");
            scenarioContext.Add("result", result2);
        }
        

        [Then("the result should be (.*)")]
        [Scope(Scenario = "Add two numbers")]
        public void ThenTheResultShouldBe(int res)
        {
            //TODO: implement assert (verification) logic
            Console.WriteLine("Result:" + scenarioContext["result"]);
            Assert.AreEqual(res, scenarioContext["result"]);
            
        }


        [Given(@"the first string is ""([^""]*)""")]
        public void GivenTheFirstStringIs(string first)
        {
            Console.WriteLine("first string="+ first);
        }

        [Given(@"the second string is ""([^""]*)""")]
        public void GivenTheSecondStringIs(string sec)
        {
            Console.WriteLine("second string=" + sec);
        }

        [When(@"the two strings are added")]
        public void WhenTheTwoStringsAreAdded()
        {
            Console.WriteLine("Two strings are adding");
        }

        [Then(@"the result should be ""([^""]*)""")]
        [Scope(Scenario = "Add two Strings")]
        public void ThenTheResultShouldBe(string saikrishna)
        {
            Assert.AreEqual("Saikrishna", saikrishna);
        }

        [Given(@"Fill below deatisl in form and submit")]
        public void GivenFillBelowDeatislInFormAndSubmit(Table table)
        {
          
            // If we have single row data
           //var employee= table.CreateInstance<Employee>();
           // Console.WriteLine(employee.name);
           // Console.WriteLine(employee.age);
           // Console.WriteLine(employee.phone);
           // Console.WriteLine(employee.email);

            //If we have multiple row data
            var employees=table.CreateSet<Employee>();
            
            foreach (var employee in employees)
            {
                Console.Write(employee.name+" | ");
                Console.Write(employee.age+" | ");
                Console.Write(employee.phone+" | ");
                Console.Write(employee.email+ " | ");

                Console.WriteLine();
            }
        }

        [Given(@"Fill below details in form and submit without objects")]
        public void GivenFillBelowDetailsInFormAndSubmitWithoutObjects(Table table)
        {
            // If we have single row data
            //dynamic data =table.CreateDynamicInstance();
            //Console.WriteLine(data.Name);
            //Console.WriteLine(data.Age);
            //Console.WriteLine(data.Phone);
            //Console.WriteLine(data.Email);

            var employeeDetails=table.CreateDynamicSet();
            foreach (var employee in employeeDetails)
            {
                Console.Write(employee.Name + " | ");
                Console.Write(employee.Age + " | ");
                Console.Write(employee.Phone + " | ");
                Console.Write(employee.Email + " | ");

                Console.WriteLine();
            }
        }

        [Given(@"Fill below details in form and submit (.*) (.*) (.*) and (.*)")]
        public void GivenFillBelowDetailsInFormAndSubmit(string name,int age,long mobile,string email)
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(mobile);
            Console.WriteLine(email);
        }

        [Given(@"This is my first step")]
        public void GivenThisIsMyFirstStep()
        {
            Console.WriteLine("Scenario Block:" + scenarioContext.CurrentScenarioBlock.ToString());
        }

        [Then(@"I wnat to know the details of this scenario")]
        public void ThenIWnatToKnowTheDetailsOfThisScenario()
        {
            Console.WriteLine("Title:"+scenarioContext.ScenarioInfo.Title);
            Console.WriteLine("Description:"+scenarioContext.ScenarioInfo.Description);
            Console.WriteLine("Tag:"+scenarioContext.ScenarioInfo.Tags[1]);
            Console.WriteLine("Feature Tag:"+scenarioContext.ScenarioInfo.ScenarioAndFeatureTags[2]);
            Console.WriteLine("Scenario Block:"+scenarioContext.CurrentScenarioBlock.ToString());
            Console.WriteLine(scenarioContext.ScenarioExecutionStatus.ToString());

        }


        public class Employee
        {
            public string name;
            public int age;
            public long phone;
            public string email;
        }
        Employee emp=new Employee();

    }
}