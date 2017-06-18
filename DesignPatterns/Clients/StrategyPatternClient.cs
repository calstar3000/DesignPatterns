using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.Strategy;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the strategy pattern. This example simulates an airport transfer service,
    /// where a passenger can choose from various transfer strategies (car, taxi, bus).
    /// </summary>
    public class StrategyPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Strategy pattern"; }
        }

        public void Run()
        {
            new AirportTransferService().ChooseTransferMethod();
        }
    }
}
