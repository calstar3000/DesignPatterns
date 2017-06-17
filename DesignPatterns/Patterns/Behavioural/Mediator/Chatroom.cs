using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Mediator
{
    /// <summary>
    /// Class representing a chatroom where participants join the chatroom
    /// and then chat to each other via a mediator.
    /// </summary>
    public class Chatroom
    {
        public void Populate()
        {
            var mediator = new Mediator();
            var anne = new Participant("Anne");
            var bob = new Participant("Bob");
            var carl = new Participant("Carl");
            var denise = new Participant("Denise");

            mediator.Register(anne);
            mediator.Register(bob);
            mediator.Register(carl);
            mediator.Register(denise);

            anne.Send(bob, "Hi Bob");
            bob.Send(anne, "Oh, hi there Anne");
        }
    }
}
