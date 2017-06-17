using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.Mediator;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the mediator pattern. This example is a chatroom, where
    /// participants send their messages to a mediator instead of directly
    /// to the other participants. That allows the mediator to implement
    /// and custom logic across the transmission of messages.
    /// </summary>
    public class MediatorPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Mediator pattern"; }
        }

        public void Run()
        {
            new Chatroom().Populate();
        }
    }
}
