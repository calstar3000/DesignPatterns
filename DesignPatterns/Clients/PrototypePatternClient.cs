using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Creational.Prototype;

namespace DesignPatterns.Clients
{
    public class PrototypePatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Prototype pattern"; }
        }

        public void Run()
        {
            new OrcArmy().Spawn();
        }
    }
}
