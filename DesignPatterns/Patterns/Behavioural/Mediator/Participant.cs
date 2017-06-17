using System;

namespace DesignPatterns.Patterns.Behavioural.Mediator
{
    /// <summary>
    /// Class representing a member of the chatroom. Instead of sending
    /// messages directly to other participants, messages are sent to the
    /// mediator, which decides how to send them.
    /// </summary>
    public class Participant
    {
        public Mediator mediator { get; set; }
        private string _name;

        public Participant(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public void Send(Participant toParticipant, string message)
        {
            mediator.Send(this, toParticipant, message);
        }

        public void Receive(Participant fromParticipant, string message)
        {
            Console.WriteLine(string.Format("{0} says: {1}", fromParticipant.Name, message));
        }
    }
}
