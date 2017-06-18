using DesignPatterns.Patterns.Behavioural.Visitor.Interfaces;

namespace DesignPatterns.Patterns.Behavioural.Visitor
{
    /// <summary>
    /// The client class which 'accepts' a 'visitor' in order to perform
    /// an operation is can't perform itself. By accepting the visitor,
    /// the client delegates control of the operation to the visitor.
    /// </summary>
    public class Client : IClient
    {
        public string Name { get; set; }
        public string Destination { get; set; }

        public Client(string name, string destination)
        {
            this.Name = name;
            this.Destination = destination;
        }

        public void Accept(IVisitor taxi)
        {
            taxi.Visit(this);
        }
    }
}
