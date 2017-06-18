
namespace DesignPatterns.Patterns.Behavioural.Visitor.Interfaces
{
    /// <summary>
    /// The visitor interface, which defines the visit method, called
    /// when the client accepts a visitor.
    /// </summary>
    public interface IVisitor
    {
        void Visit(Client client);
    }
}
