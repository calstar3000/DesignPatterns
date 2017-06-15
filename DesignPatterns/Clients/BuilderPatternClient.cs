using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Creational.Builder;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// This class represents a client of the Builder, in this case a pie shop
    /// responsible for building pies.
    /// </summary>
    public class BuilderPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Builder pattern"; }
        }

        public void Run()
        {
            new PieShop().BuildPies();
        }
    }
}
