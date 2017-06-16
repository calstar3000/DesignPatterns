using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.Command;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the command pattern. This example simulates a restaurant where
    /// orders can be added and cancelled until they are sent to the kitchen,
    /// whereby each order (command) is prepared (executed) and can no longer be
    /// cancelled.
    /// </summary>
    class CommandPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Command pattern"; }
        }

        public void Run()
        {
            new Restaurant().OpenForBusiness();
        }
    }
}
