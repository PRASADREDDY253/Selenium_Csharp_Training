using System;
using TechTalk.SpecFlow;

namespace Specflow_Selenium_Framework.StepDefinitions
{
    [Binding]
    public class UsersTestStepDefinitions
    {
        [Given(@"I got user (.*), (.*),(.*)")]
        public void GivenIGotUserLoginFirstNameLastName(string login,string fname,string lname)
        {
            Console.WriteLine(login+"--"+fname+"-----"+lname);
        }

        [Then(@"user should match to snapshoot")]
        public void ThenUserShouldMatchToSnapshoot()
        {
            Console.WriteLine();
        }
    }
}
