using TechTalk.SpecFlow.Assist;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        int n1;
        int n2;
        int Add;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
             n1 = number;
        }
        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            n2 = number;
        }
        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            int Add = n1 + n2;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Console.WriteLine("result is " + Add);
        }

        [Given(@"I input following numbers to the Calculator")]
        public void GivenIInputFollowingNumbersToTheCalculator(Table table)
        {
            /*
            var data = table.CreateSet<calculation>();

            foreach(var item in data)
            {
                Console.WriteLine($"The number is {item.Numbers}");
            }*/
            dynamic data = table.CreateDynamicSet();

            foreach (var item in data)
            {
                Console.WriteLine($"The numbers are {item.Numbers}");
            }

        }
        [Then(@"I see the result and few more details")]
        public void ThenISeeTheResultAndFewMoreDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine($"The result is going to hold the value {data.Result} with logo {data.Logo}");
        }

        public record calculation
        {
            public int Numbers { get; set; }
        }

    }
}