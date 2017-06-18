using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Creational.AbstractFactory;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// The client of the abstract factory pattern. This example simulates
    /// choosing an emperor and summoning an army (a "factory of factories").
    /// </summary>
    public class AbstractFactoryPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Abstract factory pattern"; }
        }

        public void Run()
        {
            new Emperor().SummonArmy();
        }
    }
}
