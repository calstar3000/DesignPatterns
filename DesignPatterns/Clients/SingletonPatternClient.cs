using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Singleton;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// This class represents the client of a Singleton.
    /// In this example, it is a class representing some shared state in a game
    /// (eg. whose turn it is, player scores, etc.)
    /// </summary>
    public class SingletonPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Singleton pattern"; }
        }

        public void Run()
        {
            GameState state = GameState.Instance();
            GameState state2 = GameState.Instance();
        }
    }
}
