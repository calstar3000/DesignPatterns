
namespace DesignPatterns.Patterns.Behavioural.Strategy.Interfaces
{
    /// <summary>
    /// The common interface for all airport transfer strategies.
    /// The transfer method is for each strategy to implement
    /// independently of each other and of the client that invokes them.
    /// </summary>
    public interface ITransferMethod
    {
        void Transfer();
    }
}
