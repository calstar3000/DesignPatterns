
namespace DesignPatterns.Patterns.Behavioural.Command.Inerfaces
{
    /// <summary>
    /// The order interface. Each order has a name and an execute method.
    /// The invoker doesn't know or care about how each order is executed.
    /// </summary>
    public interface IOrder
    {
        string Name { get; }
        void Execute();
    }
}
