using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.Visitor;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the visitor pattern. This example simulates a tax dispatcher,
    /// which has a taxi 'visit' a number of clients in order to take them to
    /// their destination.
    /// </summary>
    public class VisitorPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Visitor pattern"; }
        }

        public void Run()
        {
            new TaxiDispatcher().Dispatch();
        }
    }
}
