using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.ChainOfResponsibility;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the chain of responsibility pattern, in this case a customer support
    /// center responsible for handling support requests of different serverity.
    /// </summary>
    public class ChainOfResponsibilityClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Chain of responsibility pattern"; }
        }

        public void Run()
        {
            new CustomerSupportCenter().SetUp();
        }
    }
}
