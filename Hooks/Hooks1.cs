using TechTalk.SpecFlow;

namespace SpecFlowBasics.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        //Note: Before Test Run and Before Feature will be executed bue won't get printed.

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }
        [BeforeTestRun]
        public static void InitialiseTest()=> Console.WriteLine("********************This line will be executed before Test******************");
        
        [BeforeScenario("mytag")]
        public static void FirstBeforeScenario() => Console.WriteLine("********************This line will be executed before Scenario as Tag******************");
        
        [BeforeFeature]
        public static void BeforeFeature()=> Console.WriteLine("********************This line will be executed for Before Feature ******************");
        
        [AfterScenario]
        public static void AfterScenario()=> Console.WriteLine("********************This line will be executed for " + "After Scenario ******************");
        
    }
}