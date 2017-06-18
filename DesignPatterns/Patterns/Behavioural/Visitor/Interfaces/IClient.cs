
namespace DesignPatterns.Patterns.Behavioural.Visitor.Interfaces
{
    /// <summary>
    /// The client interface. A client must be able to 'accept' a 'visitor'
    /// to perform the operation that the client can't perform itself (in
    /// this case getting to their destination).
    /// </summary>
    public interface IClient
    {
        string Name { get; set; }
        string Destination { get; set; }
        void Accept(IVisitor taxi);
    }
}
