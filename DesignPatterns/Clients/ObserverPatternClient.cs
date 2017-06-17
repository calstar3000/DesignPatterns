using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.Observer;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the observer pattern. This example is a computer
    /// game sale where gamers who have wishlisted a game are notified
    /// when its price changes.
    /// </summary>
    public class ObserverPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Observer pattern"; }
        }

        public void Run()
        {
            new SummerSale().Start();
        }
    }
}
