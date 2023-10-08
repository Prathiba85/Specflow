namespace SpecFlowBasics.StepDefinitions
{
    
    [Binding]
    public class UserStepDefinition
    {
        public User person;
        private readonly ScenarioContext scenarioContext;

        public UserStepDefinition(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I enter random user data")]
        public void GivenIEnterRandomUserData()
        {
            person = new Fixture()
               .Build<User>()
               .Create();
            var email = person.Email + "@gmail.com";
            //Console.WriteLine($"The User {person.Name} has Address {person.Address} and his Email {email} with phone number {person.Phone} ");
            Console.WriteLine($"The User {person.Name} has Address {person.Address} a with phone number {person.Phone} ");
        }
       

        [Given(@"I input dynamic domain for (.* email)")]
        public void GivenIInputDynamicDomainForKarthickTechgeek_ComEmail(string email)
        {
            Console.WriteLine($"The random email address is:{email}");
        }
      
       

        public record User
        {
            public string Name { get; init; }
            public string Email { get; init; }
            public string Address { get; init; }
            public string Phone { get; init; }

        }
           
    }
}
