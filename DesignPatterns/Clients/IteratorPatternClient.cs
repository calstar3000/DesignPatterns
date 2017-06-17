using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.Iterator;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the iterator pattern. This example simulates a radio with a number
    /// of stations that are iterated over.
    /// </summary>
    public class IteratorPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Iterator pattern"; }
        }

        public void Run()
        {
            new Radio().AddStations();
        }
    }
}
