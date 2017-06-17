using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.Memento;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the memento pattern. This example simulates a search and 
    /// rescue operation, where a navigator explores a map space, saving
    /// its coordiates along the way so it can come back to its last saved
    /// position.
    /// </summary>
    public class MementoPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Memento pattern"; }
        }

        public void Run()
        {
            new SearchAndRescue().Launch();
        }
    }
}
