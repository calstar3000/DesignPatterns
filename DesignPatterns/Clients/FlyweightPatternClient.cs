using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Structural.Flyweight;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the flyweight pattern. In this example we have a canvas
    /// on which a variety of different shapes are to be painted. The shapes
    /// have a number of intrinsic properties (size, colour), and some extrinsic
    /// properties (coordinates).
    /// </summary>
    public class FlyweightPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Flyweight pattern"; }
        }

        public void Run()
        {
            new Canvas().Paint();
        }
    }
}
