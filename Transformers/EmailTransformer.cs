using System.Net.Mail;

namespace SpecFlowBasics.Transformers
{
    [Binding]
    public class EmailTransformer
    {
        [StepArgumentTransformation(@"(.*) email")]
        public  string GenerateDynamicEmailAddress(string emailAddress)
        {
            return emailAddress.Split("@")[0] + GetRandomDomain();
        }
        private string GetRandomDomain()=>new Fixture().Create<MailAddress>().Host;
        
    }
}
