using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.State;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the state pattern. This example simulates a frequent flyer
    /// loyalty program where a member can earn and spend points and have their
    /// membership state change as a result.
    /// </summary>
    public class StatePatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "State pattern"; }
        }

        public void Run()
        {
            new FrequentFlyerProgram().Start();
        }
    }
}
