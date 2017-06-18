using DesignPatterns.Patterns.Behavioural.Visitor.Interfaces;
using System;

namespace DesignPatterns.Patterns.Behavioural.Visitor
{
    /// <summary>
    /// Concrete implementation of the visitor interface. The visitor
    /// peforms an operation on the client which is passed in via the
    /// visit method.
    /// </summary>
    public class Taxi : IVisitor
    {
        private string _name;

        public Taxi(string name)
        {
            _name = name;
        }

        public void Visit(Client client)
        {
            Console.WriteLine(string.Format("The taxi driven by {0} takes {1} to destination {2}.", _name, client.Name, client.Destination));
        }
    }
}
