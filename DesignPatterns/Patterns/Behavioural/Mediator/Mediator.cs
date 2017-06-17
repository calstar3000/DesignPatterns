using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Mediator
{
    /// <summary>
    /// The key class in this pattern, the mediator sits between participants,
    /// and all messages flow through this class. This class can then implement
    /// custom logic to apply to the transmission of messages between clients.
    /// </summary>
    public class Mediator
    {
        private List<Participant> _participants;

        public Mediator()
        {
            _participants = new List<Participant>();
        }

        public void Register(Participant participant)
        {
            _participants.Add(participant);
            participant.mediator = this;
        }

        public void Send(Participant fromParticipant, Participant toParticipant, string message)
        {
            toParticipant.Receive(fromParticipant, message);
        }
    }
}
