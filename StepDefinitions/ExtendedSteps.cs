using FluentAssertions.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecFlowBasics.StepDefinitions.UserStepDefinition;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    internal class ExtendedSteps
    {
        public User person;
        private readonly ScenarioContext scenarioContext;
        
        public ExtendedSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }
        public void GivenIGetTheRandomUserData()
        {
            person = new Fixture()
               .Build<User>()
               .Create();
            scenarioContext.Set<User>(person);
            Console.WriteLine($"The User {person.Name} has Address {person.Address} a with phone number {person.Phone}");
        }
    }
}
